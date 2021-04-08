using System;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_JJPM_Software.Clases;

namespace Proyecto_JJPM_Software.Forms
{
	public partial class frmAgregarUsuario : Form
	{
        public SqlConnection ConexionBD = new SqlConnection("Data Source=LAPTOP-A1PRB8G8;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");//Alejandro
        //public SqlConnection ConexionBD = new SqlConnection("Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");
        //public SqlConnection ConexionBD = new SqlConnection("Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");
        //public SqlConnection ConexionBD = new SqlConnection("Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");
        //public SqlConnection ConexionBD = new SqlConnection("Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");
        //public SqlConnection ConexionBD = new SqlConnection("Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");

        public DataSet ds;

		public frmAgregarUsuario()
		{
			InitializeComponent();
			DG.DataSource = Seleccionar();
			TBIdInsert.Text = DG.Rows.Count.ToString();
		}


		public DataTable Seleccionar()
		{
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Usuario", ConexionBD);
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			ds = new DataSet();
			da.Fill(ds, "Usuario");
			ConexionBD.Close();
			return ds.Tables["Usuario"];
		}

		public bool Insertar(/*atributos*/ string idUsuario, string idSucursal, string Nombre, string ApellidoP, string ApellidoM, string Puesto, string Pass, string Ingreso)
		{
			ConexionBD.Open();
			SqlCommand sqlCommand = new SqlCommand(string.Format("Insert into Usuario values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", new string[] { idUsuario, idSucursal, Nombre, ApellidoP, ApellidoM, Puesto, Pass,  Ingreso }), ConexionBD);
			int filasafectadas = sqlCommand.ExecuteNonQuery();
			if (filasafectadas > 0) return true;
			else return false;
		}

		public bool Eliminar(string idUsuario)
		{
			ConexionBD.Open();
			SqlCommand sqlCommand = new SqlCommand(string.Format("Delete from Usuario where IdUsuario = {0}", idUsuario), ConexionBD);
			int filasafectadas = sqlCommand.ExecuteNonQuery();
			ConexionBD.Close();
			if (filasafectadas > 0) return true;
			else return false;
		}


        private void BTNInsert_Click_1(object sender, EventArgs e)
        {
            //Tomamos el valor de la fecha
            string Fecha = "";
            DateTime fechita = dateTPIngreso.Value.Date;
            DateTime Fechahoy = DateTime.Now;
            Fecha = dateTPIngreso.Value.Date.ToShortDateString();
            if (fechita.Date>Fechahoy.Date)
            {
                MessageBox.Show("Ingresa una fecha que no haya pasado aun.","Dato Erroneo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Fecha = "";
            }

            //Tomamos el valor del Tipo de Usuario
            string Tipo = "";
            switch (cBoxTipo.Text)
            {
                case "Gerente":
                    Tipo = "Gerente";
                    break;
                case "Vendedor":
                    Tipo = "Vendedor";
                    break;
                case "Panadero":
                    Tipo = "Panadero";
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo de usuario valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
            //Generar el Usuario
            string Nombre = "";
            string Nombre2 = "";//Opcional
            string ApellidoP = "";
            string ApellidoM = "";//Opcional
            string UsuarioFinal = "";
            Random r = new Random();

            //Tomamos los valores de 2do nombre y apellido Materno en caso de tenerlos
            if (TBNombre2.TextLength > 0 && !(string.IsNullOrWhiteSpace(TBNombre2.Text)))
            {
                Nombre2 = TBNombre2.Text;
            }
            if (TBAm.TextLength > 0 && !(string.IsNullOrWhiteSpace(TBAm.Text)))
            {
                ApellidoM = TBAm.Text;
            }

            try
            {
                //Verificacion de que haya Nombre y Apellido Paterno
                if (string.IsNullOrWhiteSpace(TBNombre.Text) || string.IsNullOrWhiteSpace(TBAp.Text) || Tipo == "" || string.IsNullOrWhiteSpace(TBPass.Text) || Fecha == "")
                {
                    MessageBox.Show("Falta ingresar informacion necesaria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Nombre = TBNombre.Text;
                    ApellidoP = TBAp.Text;

                    //Encritamos la Contraseña
                    string PassEncriptada = Encrypt.GetSHA256(TBPass.Text);

                    //Seleccion de Usuario (En caso de tener 2 nombres)
                    if (string.IsNullOrWhiteSpace(TBNombre2.Text))
                    {
                        UsuarioFinal = ApellidoP + (Nombre.Substring(0, 1).ToUpper()) + r.Next(10, 99);
                        MessageBox.Show("Nuevo Usuario Generado: " + UsuarioFinal, "Usuario Generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Insertamos los Datos en la BD
                        if (Insertar(TBIdInsert.Text, Nombre, ApellidoP, ApellidoM, UsuarioFinal, PassEncriptada, Tipo, Fecha))
                        {
                            MessageBox.Show("Datos insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TBIdInsert.Text = DG.Rows.Count.ToString();
                            DG.DataSource = Seleccionar();

                            //Limpiamos los valores
                            TBNombre.Clear();
                            TBNombre2.Clear();
                            TBAp.Clear();
                            TBAm.Clear();
                            TBPass.Clear();
                            TBNombre.Focus();
                        }
                    }
                    else
                    {
                        UsuarioFinal = ApellidoP + (Nombre.Substring(0, 1).ToUpper()) + (Nombre2.Substring(0, 1).ToUpper()) + r.Next(10, 99);
                        MessageBox.Show("Nuevo Usuario Generado: "+UsuarioFinal,"Usuario Generado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                        //Insertamos los Datos en la BD
                        if (Insertar(TBIdInsert.Text, Nombre, ApellidoP, ApellidoM, UsuarioFinal, PassEncriptada, Tipo, Fecha))
                        {
                            MessageBox.Show("Datos insertados correctamente","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            TBIdInsert.Text = DG.Rows.Count.ToString();
                            DG.DataSource = Seleccionar();

                            //Limpiamos los valores
                            TBNombre.Clear();
                            TBNombre2.Clear();
                            TBAp.Clear();
                            TBAm.Clear();
                            TBPass.Clear();
                            TBNombre.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex);
            }
        }

        private void BTNDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que deseas eliminar a este Usuario?", "Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dr==DialogResult.Yes)
            {
                if (Eliminar(TBIdDelete.Text))
                {
                    MessageBox.Show("Datos Eliminados con exito.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    TBIdInsert.Text = DG.Rows.Count.ToString();
                    DG.DataSource = Seleccionar();
                }
                else
                {
                    MessageBox.Show("Datos No Eliminados","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                } 
            }
            
        }
    }
}
