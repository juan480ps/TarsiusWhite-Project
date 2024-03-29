﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClasesTarsius
{
    public class Venta
    {
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
                string textoCMD = "INSERT INTO Venta (FechaPedido, Cliente) output INSERTED.id VALUES (@fechaventa, @cliente)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlParameter p1 = new SqlParameter("@fechaventa", v.fechaVenta);
                SqlParameter p2 = new SqlParameter("@Cliente", v.cliente.IdCliente);

                p1.SqlDbType = System.Data.SqlDbType.DateTime;
                p2.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                int idVenta = (int)cmd.ExecuteScalar();

                foreach (DetalleVenta dv in v.detalleVenta)
                {
                    string textoCMD2 = "INSERT INTO DetalleVenta(IdVenta, cantidad, articulo, precioventa) VALUES (@IdVenta, @cantidad, @categoria, @precioventa)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    SqlParameter p3 = new SqlParameter("@IdVenta", idVenta);
                    SqlParameter p4 = new SqlParameter("@cantidad", dv.cantidad);
                    SqlParameter p5 = new SqlParameter("@articulo", dv.articulo);
                    SqlParameter p6 = new SqlParameter("@precioventa", dv.PrecioVenta);

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
