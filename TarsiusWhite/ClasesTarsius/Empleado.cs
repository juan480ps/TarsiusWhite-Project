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

        private int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public _sexo sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public _tipoDocumento tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public Empleado()
        {

        }

        public static List<Empleado> listaEmpleados = new List<Empleado>();

        public static void agregarEmpleado(Empleado emp)
        {
            //listaEmpleados.Add(emp);
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {

                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into empleado VALUES (@Nombre,@Apellido,@Sexo,@FechaNacimiento,@TipoDocumento,@NroDocumento,@Direccion,@Telefono,@Email,@Acceso,@Usuario,@Password)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", emp.nombre);
                SqlParameter p2 = new SqlParameter("@Apellido", emp.apellido);
                SqlParameter p3 = new SqlParameter("@Sexo", emp.sexo);
                SqlParameter p4 = new SqlParameter("@FechaNacimiento", emp.fechaNacimiento);
                SqlParameter p5 = new SqlParameter("@TipoDocumento", emp.tipoDocumento);
                SqlParameter p6 = new SqlParameter("@NroDocumento", emp.nroDocumento);
                SqlParameter p7 = new SqlParameter("@Direccion", emp.direccion);
                SqlParameter p8 = new SqlParameter("@Telefono", emp.telefono);
                SqlParameter p9 = new SqlParameter("@Email", emp.email);
                SqlParameter p10 = new SqlParameter("@Acceso", emp.acceso);
                SqlParameter p11 = new SqlParameter("@Usuario", emp.usuario);
                SqlParameter p12 = new SqlParameter("@Password", emp.password);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.Date;
                p5.SqlDbType = SqlDbType.VarChar;
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
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);
                cmd.Parameters.Add(p10);
                cmd.Parameters.Add(p11);
                cmd.Parameters.Add(p12);

                cmd.ExecuteNonQuery();

            }
        }

        public static void editarEmpleado(int indice, Empleado emp)
        {
            // LISTA EMPLEADO
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Proveedor (nombre, apellido, sexo, fechaNacimiento, tipoDocumento, nroDocumento, direccion, telefono, email, acceso, usuario, password) VALUES (@nombre, @apellido, @sexo, @fechaNacimiento, @tipoDocumento, @nroDocumento, @direccion, @telefono, @email, @acceso, @usuario, @password)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", emp.nombre);
                SqlParameter p2 = new SqlParameter("@apellido", emp.apellido);
                SqlParameter p3 = new SqlParameter("@sexo", emp.sexo);
                SqlParameter p4 = new SqlParameter("@fechaNacimiento", emp.fechaNacimiento);
                SqlParameter p5 = new SqlParameter("@tipoDocumento", emp.tipoDocumento);
                SqlParameter p6 = new SqlParameter("@nroDocumento", emp.nroDocumento);
                SqlParameter p7 = new SqlParameter("@direccion", emp.direccion);
                SqlParameter p8 = new SqlParameter("@telefono", emp.telefono);
                SqlParameter p9 = new SqlParameter("@email", emp.email);
                SqlParameter p10 = new SqlParameter("@acceso", emp.acceso);
                SqlParameter p11 = new SqlParameter("@usuario", emp.usuario);
                SqlParameter p12 = new SqlParameter("@password", emp.password);
                //SqlParameter p13 = new SqlParameter("@idEmpleado", emp.idEmpleado);


                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.Date;
                p5.SqlDbType = SqlDbType.VarChar;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.VarChar;
                p8.SqlDbType = SqlDbType.VarChar;
                p9.SqlDbType = SqlDbType.VarChar;
                p10.SqlDbType = SqlDbType.VarChar;
                p11.SqlDbType = SqlDbType.VarChar;
                p12.SqlDbType = SqlDbType.VarChar;
                //p13.SqlDbType = SqlDbType.Int;

                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);
                cmd.Parameters.Add(p10);
                cmd.Parameters.Add(p11);
                cmd.Parameters.Add(p12);
                //cmd.Parameters.Add(p13);

                cmd.ExecuteNonQuery();


                Empleado.listaEmpleados[indice] = emp;

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
                    empleado.sexo = (Empleado._sexo)elLectorDeDatos.GetInt32(3);
                    empleado.fechaNacimiento = elLectorDeDatos.GetDateTime(4);
                    empleado.tipoDocumento = (Empleado._tipoDocumento)elLectorDeDatos.GetInt32(5);
                    empleado.nroDocumento = elLectorDeDatos.GetString(6);
                    empleado.direccion = elLectorDeDatos.GetString(7);
                    empleado.telefono = elLectorDeDatos.GetString(8);
                    empleado.email = elLectorDeDatos.GetString(9);
                    empleado.acceso = elLectorDeDatos.GetString(10);
                    empleado.usuario = elLectorDeDatos.GetString(11);
                    empleado.password = elLectorDeDatos.GetString(12);



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

