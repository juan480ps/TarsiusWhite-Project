using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace ClasesTarsius
{
    public class Empleado
    {
        //public enum _sexo
        //{
        //    Femenino,
        //    Masculino
        //}

        //public enum _tipoDocumento
        //{
        //    CI,
        //    DNI
        //}

        private int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
       // public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }


        public static List<Empleado> listaEmpleados = new List<Empleado>();

        public static void agregarEmpleado(Empleado emp)
        {
            //listaEmpleados.Add(emp);
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into empleado VALUES (@Nombre,@Apellido,@Sexo,@FechaNacimiento,@NroDocumento,@Direccion,@Telefono,@Email,@Acceso,@Usuario,@Password)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = emp.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, bool id = false)
        {
            //PARAMETROS
            SqlParameter p1 = new SqlParameter("@nombre", this.nombre);
            SqlParameter p2 = new SqlParameter("@Apellido", this.apellido);
            SqlParameter p3 = new SqlParameter("@Sexo", this.sexo);
            SqlParameter p4 = new SqlParameter("@FechaNacimiento", this.fechaNacimiento);
           // SqlParameter p5 = new SqlParameter("@TipoDocumento", this.tipoDocumento);
            SqlParameter p6 = new SqlParameter("@NroDocumento", this.nroDocumento);
            SqlParameter p7 = new SqlParameter("@Direccion", this.direccion);
            SqlParameter p8 = new SqlParameter("@Telefono", this.telefono);
            SqlParameter p9 = new SqlParameter("@Email", this.email);
            SqlParameter p10 = new SqlParameter("@Acceso", this.acceso);
            SqlParameter p11 = new SqlParameter("@Usuario", this.usuario);
            SqlParameter p12 = new SqlParameter("@Password", this.password);

            //Le decimos a los parametros de que tipo de datos son
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.Date;
            //p5.SqlDbType = SqlDbType.VarChar;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.VarChar;
            p8.SqlDbType = SqlDbType.VarChar;
            p9.SqlDbType = SqlDbType.VarChar;
            p10.SqlDbType = SqlDbType.VarChar;
            p11.SqlDbType = SqlDbType.VarChar;
            p12.SqlDbType = SqlDbType.VarChar;

            //Agragamos los parametros al command
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            //cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            cmd.Parameters.Add(p11);
            cmd.Parameters.Add(p12);

            if (id == true)
            {
                cmd.ExecuteNonQuery();
            }

            return cmd;
        }

        public static void editarEmpleado(int indice, Empleado emp)
        {
            // LISTA EMPLEADO
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Proveedor (nombre, apellido, sexo, fechaNacimiento, tipoDocumento, nroDocumento, direccion, telefono, email, acceso, usuario, password) VALUES (@nombre, @apellido, @sexo, @fechaNacimiento, @tipoDocumento, @nroDocumento, @direccion, @telefono, @email, @acceso, @usuario, @password)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                cmd = emp.ObtenerParametros(cmd, true);
            }
        }


        public static void eliminarEmpleado(Empleado emp)
        {
            //listaEmpleados.Remove(emp);

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string SENTENCIA_SQL = "delete from Proveedor where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p13 = new SqlParameter("@idEmpleado", emp.idEmpleado);
                p13.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p13);

                cmd.ExecuteNonQuery();
            }
        }

        public static Empleado ObtenerEmpleado(int idEmpleado)
        {
            Empleado empleado = null;

            if (listaEmpleados.Count == 0)
            {
                Empleado.ObtenerEmpleados();
            }

            foreach (Empleado emp in listaEmpleados)
            {
                if (emp.idEmpleado == idEmpleado)
                {
                    empleado = emp;
                    break;
                }
            }

            return empleado;
        }


        public static List<Empleado> ObtenerEmpleados()
        {
            Empleado empleado;
            listaEmpleados.Clear();
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Empleado";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    empleado = new Empleado();
                    empleado.idEmpleado = elLectorDeDatos.GetInt32(0);
                    empleado.nombre = elLectorDeDatos.GetString(1);
                    empleado.apellido = elLectorDeDatos.GetString(2);
                    empleado.sexo = elLectorDeDatos.GetString(3);
                    empleado.fechaNacimiento = elLectorDeDatos.GetDateTime(4);
                    //empleado.tipoDocumento = elLectorDeDatos.GetString(5);
                    empleado.nroDocumento = elLectorDeDatos.GetString(5);
                    empleado.direccion = elLectorDeDatos.GetString(6);
                    empleado.telefono = elLectorDeDatos.GetString(7);
                    empleado.email = elLectorDeDatos.GetString(8);
                    empleado.acceso = elLectorDeDatos.GetString(9);
                    empleado.usuario = elLectorDeDatos.GetString(10);
                    empleado.password = elLectorDeDatos.GetString(11);

                    listaEmpleados.Add(empleado);
                }

                return listaEmpleados;
            }
        }


        public override string ToString()
        {
            return nombre;
        }
    }
}

