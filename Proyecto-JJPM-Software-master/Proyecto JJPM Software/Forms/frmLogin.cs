using Proyecto_JJPM_Software.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_JJPM_Software.Forms
{
    public partial class frmLogin : Form
    {
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;
        ConexionBD Log = new ConexionBD();

        public frmLogin()
        {
            InitializeComponent();
        }

        //Boton para minimizar la ventana.
        private void pboxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Boton para regresar el tamaño de la ventana al anterior.
        private void pboxRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pboxMax.Visible = true;
            pboxRestore.Visible = false;
        }

        //Boton para agrandar la ventana a tamaño completo.
        private void pboxMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pboxMax.Visible = false;
            pboxRestore.Visible = true;
        }

        //Boton para cerrar la ventana.
        private void pboxClose_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("¿Estas seguro que quieres cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Boton para mover la ventana.
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        //Boton para guardar el valor del ultimo click.
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Log.AbrirBD();
            string[] TipUsuario=new string[2];
            string PassEncriptada = "";
            
            //Encriptamos la Contraseña
            PassEncriptada = Encrypt.GetSHA256(txtBoxPassword.Text.Trim());

            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text)||string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Ingresa tu usuario y contraseña.", "Falta de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    TipUsuario = Log.Login(txtBoxUsername.Text, PassEncriptada);
                    if (TipUsuario[0] == "Gerente")
                    {
                        this.Hide();
                        var form1 = new frmPrincipal(TipUsuario);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }
                    else if (TipUsuario[0] == "Vendedor")
                    {
                        this.Hide();
                        var form1 = new frmPrincipal(TipUsuario);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();

                    }
                    else if (TipUsuario[0] == "Panadero")
                    {
                        this.Hide();
                        var form1 = new frmPrincipal(TipUsuario);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }
                    else if (TipUsuario[0] == "Admin")
                    {
                        this.Hide();
                        var form1 = new frmPrincipal(TipUsuario);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario/contraseña invalida.");
                        Log.CerrarBD();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El usuario/contraseña invalida.", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void pboxPassVisual_Click(object sender, EventArgs e)
        {
            //Esto hara que se pueda ver o no, la contraseña.
            if (txtBoxPassword.PasswordChar == '·')
            {
                txtBoxPassword.PasswordChar ='\0';
            }
            else
            {
                txtBoxPassword.PasswordChar = '·';
            }
        }

        
        /*
        private void button2_Click(object sender, EventArgs e) //AutocompletarGerente
        {
            txtBoxPassword.Text = "123";
            txtBoxUsername.Text = "Gerente1";
        }

        private void button3_Click(object sender, EventArgs e)  //Autocmpletar Vendedor
        {
            txtBoxPassword.Text = "123";
            txtBoxUsername.Text = "Vendedor1";
        }
        */

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtBoxUsername.Focus();
        }
    }
}

