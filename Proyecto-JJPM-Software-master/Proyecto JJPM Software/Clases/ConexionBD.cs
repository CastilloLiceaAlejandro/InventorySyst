using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Proyecto_JJPM_Software.Clases
{
    class ConexionBD
    {
        string Cadena = "Data Source=LAPTOP-A1PRB8G8;Initial Catalog=PruebaCSharpSQL;Integrated Security= True";//Alejandro
        //string Cadena = "Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True";
        //string Cadena = "Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True";
        //string Cadena = "Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True";
        //string Cadena = "Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True";
        //string Cadena = "Data Source=;Initial Catalog=PruebaCSharpSQL;Integrated Security= True";

        public SqlConnection ConectarBD = new SqlConnection();

        public ConexionBD()
        {
            ConectarBD.ConnectionString = Cadena;
        }

        public void AbrirBD()
        {
            try
            {
                ConectarBD.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: "+ ex);
            }
        }

        public void CerrarBD()
        {
            ConectarBD.Close();
        }

        public string[] Login(string Usuario, string Contra)
        {
            string[] TipoUsuario=new string[2];
            try
            {
                //Toma los valores de Usuario y Pass.
                //Evitando SQL Injection
                SqlCommand cmd = new SqlCommand("Select * from Usuario where Usuario=@Usuario and Pass=@Pass", ConectarBD);
                cmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
                cmd.Parameters.Add(new SqlParameter("@Pass", Contra));
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][2].ToString() == "Gerente")
                    {
                        TipoUsuario[0] = "Gerente";
                        TipoUsuario[1] = dt.Rows[0][3].ToString();
                        return TipoUsuario;
                    }
                    else if (dt.Rows[0][2].ToString() == "Vendedor")
                    {
                        TipoUsuario[0] = "Vendedor";
                        TipoUsuario[1] = dt.Rows[0][3].ToString();
                        return TipoUsuario;
                    }
                    else if (dt.Rows[0][2].ToString() == "Panadero")
                    {
                        TipoUsuario[0] = "Panadero";
                        TipoUsuario[1] = dt.Rows[0][3].ToString();
                        return TipoUsuario;
                    }
                    else
                    {
                        TipoUsuario[0] = "Admin";
                        TipoUsuario[1] = dt.Rows[0][3].ToString();
                        return TipoUsuario;
                    }
                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: \n" + ex,"Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

    }
}

