using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Cliente
    {
        public enum _sexo
        {
            Femenino,
            Masculino
        }

        public enum _tipoDocumento
        {
            CI,
            DNI

        }

        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public _sexo sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public _tipoDocumento tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }



        public Cliente()
        {

        }

        public static List<Cliente> listaClientes= new List<Cliente>();

        public static void AgregarCliente(Cliente c)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "INSERT INTO Cliente (nombre, apellido, sexo, FechaNacimiento, tipodocumento, NroDocumento, direccion, telefono, email)VALUES (@nombre, @apellido, @sexo, @FechaNacimiento, @tipodocumento, @NroDocumento, @direccion, @telefono, @email)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Cliente where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id", cliente.idCliente);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void EditarCliente(int index, Cliente c)
        {

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Cliente SET nombre = @nombre, apellido = @apellido, sexo = @sexo, FechaNacimiento = @FechaNacimiento,  tipodocumento = @tipodocumento, direccion = @direccion, email = @email, NroDocumento = @NroDocumento where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = c.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Cliente> ObtenerCliente()
        {
            Cliente cliente;

            listaClientes.Clear();

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Cliente";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    cliente = new Cliente();
                    cliente.idCliente = elLectorDeDatos.GetInt32(0);
                    cliente.nombre = elLectorDeDatos.GetString(1);
                    cliente.apellido = elLectorDeDatos.GetString(2);
                    cliente.sexo = (_sexo)elLectorDeDatos.GetInt32(3);
                    cliente.fechaNacimiento = elLectorDeDatos.GetDateTime(4);
                    cliente.tipoDocumento = (_tipoDocumento)elLectorDeDatos.GetInt32(5);
                    cliente.direccion = elLectorDeDatos.GetString(6);
                    cliente.email = elLectorDeDatos.GetString(7);
                    cliente.nroDocumento = elLectorDeDatos.GetString(8);
                    cliente.telefono = elLectorDeDatos.GetString(9);

                    listaClientes.Add(cliente);

                }
            }

            return listaClientes;
        }

        public override string ToString()
        {
            return this.nombre;
        }
        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@nombre", this.nombre);
            SqlParameter p2 = new SqlParameter("@apellido", this.apellido);
            SqlParameter p3 = new SqlParameter("@sexo", this.sexo);
            SqlParameter p4 = new SqlParameter("@fechanacimiento", this.fechaNacimiento);
            SqlParameter p5 = new SqlParameter("@tipodocumento	", this.tipoDocumento);
            SqlParameter p6 = new SqlParameter("@direccion", this.direccion); 
            SqlParameter p7 = new SqlParameter("@email	", this.email);
            SqlParameter p8 = new SqlParameter("@nrodocumento", this.nroDocumento);
            SqlParameter p9 = new SqlParameter("@telefono", this.telefono);


            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.DateTime;
            p5.SqlDbType = SqlDbType.Int;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.VarChar;
            p8.SqlDbType = SqlDbType.VarChar;
            p9.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;

        }


        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p9 = new SqlParameter("@Id", this.idCliente);
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p9);
            return cmd;
        }                  
    }
}
