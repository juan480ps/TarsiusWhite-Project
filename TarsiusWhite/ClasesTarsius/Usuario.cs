using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Usuario
    {
        public static void CrearUsuario(string usuario, string password)
        {
            string password_protegido = EncodePassword(password);
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "INSERT INTO USUARIO (usuario, password) values(@Usuario, @Password)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@Usuario", usuario.Trim());
                p1.SqlDbType = SqlDbType.VarChar;
                SqlParameter p2 = new SqlParameter("@Password", password_protegido);
                p2.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Login.EscribirLog("SqlException", ex.Message);
                }
            }
        }

        public static bool Autenticar(string usuario, string password)
        {
            string password_protegido = EncodePassword(password);
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT Usuario, password from Usuario where Usuario = @Usuario and password = @Password";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@Usuario", usuario.Trim());
                p1.SqlDbType = SqlDbType.VarChar;
                SqlParameter p2 = new SqlParameter("@Password", password_protegido);
                p2.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    Login.EscribirLog("SqlException", ex.Message);
                    return false;
                }
            }
        }


        public static string EncodePassword(string originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            string salt = "0d71ee4472658cd5874c5578410a9d8611fc9aef";
            string passwordSalt = salt + originalPassword;
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(passwordSalt);
            byte[] hash = sha1.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }
    }
}
