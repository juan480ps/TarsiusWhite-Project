﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ClasesTarsius
{
    public class Articulo
    {
        public enum _categoria
        {
            ventaLibre,
            bajoReceta
        }

        public enum _presentacion
        {
            comprimido,
            pastillaBlanda,
            jarabe
        }

        public int idArticulo { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public _categoria categoria { get; set; }
        public _presentacion presentacion { get; set; }

        public Articulo()
        {

        }

        public static List<Articulo> listaArticulos = new List<Articulo>();

        public static void agregarArticulo(Articulo art)
        {
            //listaArticulos.Add(art);

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "INSERT INTO Articulo VALUES (@codigo, @nombre, @descripcion , @categoria, @presentacion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = art.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        public static void editarArticulo(Articulo art, int indice)
        {
            //Articulo.listaArticulos[indice] = art;

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Articulo SET codigo = @codigo, nombre = @nombre, descripcion = @descripcion, categoria = @categoria, categoria = @categoria, presentacion = @presentacion";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = art.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }
        public static void eliminarArticulo(Articulo art)
        {
            // listaArticulos.Remove(art);

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Articulo where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id", art.idArticulo);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static List<Articulo> ObtenerArticulos()
        {
            // return listaArticulos;

            Articulo art;

            listaArticulos.Clear();

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Articulo";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    art = new Articulo();
                    art.idArticulo = elLectorDeDatos.GetInt32(0);
                    art.codigo = elLectorDeDatos.GetString(1);
                    art.nombre = elLectorDeDatos.GetString(2);
                    art.descripcion = elLectorDeDatos.GetString(3);
                    art.categoria = (_categoria)elLectorDeDatos.GetInt32(4);
                    art.presentacion = (_presentacion)elLectorDeDatos.GetInt32(5);

                    listaArticulos.Add(art);

                }
            }

            return listaArticulos;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@codigo", this.codigo);
            SqlParameter p2 = new SqlParameter("@nombre", this.nombre);
            SqlParameter p3 = new SqlParameter("@descripcion", this.descripcion);
            SqlParameter p4 = new SqlParameter("@presentacion", this.presentacion);
            SqlParameter p5 = new SqlParameter("@categoria", this.categoria);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;

        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {

            SqlParameter p9 = new SqlParameter("@id", this.idArticulo);
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p9);
            return cmd;
        }
    }
}

