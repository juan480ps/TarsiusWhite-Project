using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClasesTarsius
{
    public class Venta
    {
        //int IdVenta;
        //string FechaVenta;
        //string TipoComprobante;
        //public List<DetalleVenta> detalleVenta = new List<DetalleVenta>();
        ////hola
        ///
        public Cliente cliente { get; set; }
        public DateTime fechaVenta { get; set; }
        public List<DetalleVenta> detalleVenta = new List<DetalleVenta>();

        public static List<Venta> listaVentas = new List<Venta>();

        public static void Agregar(Venta v)
        {
            //listaPedidos.Add(p);
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                //cabecera
                string textoCMD = "INSERT INTO Venta (fechaventa, cliente) output INSERTED.id VALUES (@fechaventa, @cliente)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //parametros
                SqlParameter p1 = new SqlParameter("@fechaventa", v.fechaVenta);
                SqlParameter p2 = new SqlParameter("@cliente", v.cliente.idCliente);

                p1.SqlDbType = System.Data.SqlDbType.DateTime;
                p2.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                int idVenta = (int)cmd.ExecuteScalar();


                //DETALLE
                foreach (DetalleVenta dv in v.detalleVenta)
                {
                    //insert para el detalle
                    string textoCMD2 = "INSERT INTO DetalleVenta(IdVenta, cantidad, categoria, precioventa) VALUES (@IdVenta, @cantidad, @categoria, @precioventa)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    //Pasamos los parametros

                    SqlParameter p3 = new SqlParameter("@IdVenta", idVenta);
                    SqlParameter p4 = new SqlParameter("@cantidad", dv.cantidad);
                    SqlParameter p5 = new SqlParameter("@categoria", dv.categoria.IDCategoria);
                    SqlParameter p6 = new SqlParameter("@precioventa", dv.categoria.IDCategoria);

                    cmd2.Parameters.Add(p3);
                    cmd2.Parameters.Add(p4);
                    cmd2.Parameters.Add(p5);
                    cmd2.Parameters.Add(p6);

                    cmd2.ExecuteNonQuery();
                }
            }
        }
        public static void Eliminar(Venta v)
        {
            listaVentas.Remove(v);
        }

        public static List<Venta> Obtener()
        {
            return listaVentas;
        }

        public override string ToString()
        {
            return this.cliente.nombre;
        }
    }
}
