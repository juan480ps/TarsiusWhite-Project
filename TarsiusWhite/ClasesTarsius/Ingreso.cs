using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClasesTarsius
{
   public class Ingreso
    {
        public int IdIngreso;
       public DateTime FechaIngreso;
       public string TipoComprobante;
       public string Serie;
       public string Correlativo;
       public string Igv;
       public string Estado;


        public List<DetalleIngreso> detalleIngreso = new List<DetalleIngreso>();

        public static List<Ingreso> listaIngreso = new List<Ingreso>();

        public static void Agregar(Ingreso p)
        {

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                //cabecera
                string textoCMD = "INSERT INTO Ingreso ( FechaIngreso, Serie) output INSERTED.id VALUES (  @FechaIngreso,  @Serie)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //parametros
                SqlParameter p1 = new SqlParameter("@FechaIngreso", p.FechaIngreso);
                SqlParameter p2 = new SqlParameter("@Serie", p.Serie);

                p1.SqlDbType = System.Data.SqlDbType.DateTime;
                p2.SqlDbType = System.Data.SqlDbType.VarChar;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                int id_ingreso = (int)cmd.ExecuteScalar();


                //DETALLE
                foreach (DetalleIngreso dp in p.detalleIngreso)
                {
                    //insert para el detalle
                    string textoCMD2 = "INSERT INTO IngresoDetalle (IdIngreso, TipoComprobante, Igv, Estado) VALUES (@IdIngreso, @TipoComprobante, @Igv, @Estado)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    //Pasamos los parametros

                    SqlParameter p3 = new SqlParameter("@IdIngreso", id_ingreso);
                    SqlParameter p4 = new SqlParameter("@TipoComprobante", dp.TipoComprobante);
                    SqlParameter p5 = new SqlParameter("@Igv", dp.Igv);
                    SqlParameter p6 = new SqlParameter("@Estado", dp.Estado);



                    cmd2.Parameters.Add(p3);
                    cmd2.Parameters.Add(p4);
                    cmd2.Parameters.Add(p5);
                    cmd2.Parameters.Add(p6);

                    cmd2.ExecuteNonQuery();
                }
            }
        }
        public static void Eliminar(Ingreso p)
        {
            listaIngreso.Remove(p);
        }

        public static List<Ingreso> Obtener()
        {
            return listaIngreso;
        }

       
    }
}

