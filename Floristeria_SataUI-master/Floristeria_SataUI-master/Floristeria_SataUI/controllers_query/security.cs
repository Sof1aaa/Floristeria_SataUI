using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Floristeria_SataUI;

namespace Floristeria_SataUI.Controllers_query
{
    public class security
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }


        public void login(int doc, string pass, Form parentForm)
        {
            using (var conexion = new SqlConnection(@"server=.;database=Floristeria;integrated security=true"))
            {
                conexion.Open();
                SqlCommand sqlc = new SqlCommand("SELECT Documento,Nombre,Cargo FROM Empleados WHERE Documento = @doc AND Contraseña = @pass", conexion);
                sqlc.Parameters.Add("@doc", SqlDbType.VarChar).Value = doc;
                sqlc.Parameters.Add("@pass", SqlDbType.VarChar).Value = HashPassword(pass);


                SqlDataReader reader = sqlc.ExecuteReader();
                if(reader.Read())
                {
                    string nombre = reader["Nombre"].ToString();
                    string cargo = reader["Cargo"].ToString();
                    Form1 principal = new Form1(nombre, cargo);
                    principal.Show();
                    MessageBox.Show("Bienvenido " + nombre);
                    parentForm.Hide();




                }
                else
                {
                   MessageBox.Show("Usuario o contraseña incorrectos");

                }

            }

        }



    }
}
