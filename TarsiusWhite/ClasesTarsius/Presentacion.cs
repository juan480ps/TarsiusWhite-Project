using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesTarsius
{
    public class Presentacion
    {
        private int idPresentacion { get; set; }
        public string nombrePresentacion { get; set; }
        public string descripcionPresentacion { get; set; }

        public Presentacion()
        {

        }

        public static List<Presentacion> listaPresentacion = new List<Presentacion>();

        public static void agregarPresentacion(Presentacion pre)
        {
            //listaPresentacion.Add(pre);
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {

                con.Open(); 
                string textoCmd = "insert into Presentacion (nombrePresentacion, descripcionPresentacion) VALUES (@nombrePresentacion, @descripcionPresentacion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@nombrePresentacion", pre.nombrePresentacion);
                SqlParameter p2 = new SqlParameter("@descripcionPresentacion", pre.descripcionPresentacion);

                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();

            }
        }

        public static void editarPresentacion(Presentacion pre, int indice)
        {
            //Presentacion.listaPresentacion[indice] = pre;
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Presentacion SET nombrePresentacion = @nombrePresentacion, descripcionPresentacion = @descripcionPresentacion where Idpresentacion = @Idpresentacion";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlParameter p1 = new SqlParameter("@nombrePresentacion", pre.nombrePresentacion);
                SqlParameter p2 = new SqlParameter("@descripcionPresentacion", pre.descripcionPresentacion);

                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();

            }
        }


        public static void eliminarPresentacion(Presentacion pre)
        {
            //listaPresentacion.Remove(pre);
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string SENTENCIA_SQL = "delete from Presentacion where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p3 = new SqlParameter("@idPresentacion", pre.idPresentacion);
                p3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }
        public static Presentacion obtenerPresentacion(int idPresentacion)
        {
            Presentacion presentacion = null;

            if (listaPresentacion.Count == 0)
            {
                Presentacion.obtenerPresentacion();
            }

            foreach (Presentacion pre in listaPresentacion)
            {
                if (pre.idPresentacion == idPresentacion)
                {
                    presentacion = pre;
                    break;
                }
            }

            return presentacion;
        }
        public static List<Presentacion> obtenerPresentacion()
        {
            Presentacion presentacion;
            listaPresentacion.Clear();
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {

                con.Open();
                string textoCMD = "Select * from Presentacion";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    presentacion = new Presentacion();
                    presentacion.idPresentacion = elLectorDeDatos.GetInt32(0);
                    presentacion.nombrePresentacion = elLectorDeDatos.GetString(1);
                    presentacion.descripcionPresentacion = elLectorDeDatos.GetString(2);

                    listaPresentacion.Add(presentacion);
                }

                return listaPresentacion;
            }
        }

        public override string ToString()
        {
            return nombrePresentacion;
        }
    }
}
