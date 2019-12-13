using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

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
        public Categoria categoria { get; set; }
        public Presentacion presentacion { get; set; }

        public Articulo articulo;

        public List<Articulo> listaArticulo = new List<Articulo>();

        public static List<Articulo> listaArticulos = new List<Articulo>();

        public static void agregarArticulo(Articulo art)
        {           
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();                
                string textoCmd = "INSERT INTO Articulo VALUES (@codigo, @nombre, @descripcion , @categoria, @presentacion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = art.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        public static void editarArticulo(Articulo art)//, int indice)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = @"UPDATE Articulo SET codigo = @codigo, Nombre = @nombre, descripcion = @descripcion, categoria = @categoria, presentacion = @presentacion where idarticulo = @idarticulo";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = art.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
            //string rpta = "";
            //SqlConnection SqlCon = new SqlConnection();
            //try
            //{
            //    //Código
            //    SqlCon.ConnectionString = Conexion.CADENA_CONEXION;
            //    SqlCon.Open();
            //    //Establecer el Comando
            //    SqlCommand SqlCmd = new SqlCommand();
            //    SqlCmd.Connection = SqlCon;
            //    SqlCmd.CommandText = "speditar_articulo";
            //    SqlCmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter ParIdarticulo = new SqlParameter();
            //    ParIdarticulo.ParameterName = "@idarticulo";
            //    ParIdarticulo.SqlDbType = SqlDbType.Int;
            //    ParIdarticulo.Value = Articulo.Idarticulo;
            //    SqlCmd.Parameters.Add(ParIdarticulo);

            //    SqlParameter ParCodigo = new SqlParameter();
            //    ParCodigo.ParameterName = "@codigo";
            //    ParCodigo.SqlDbType = SqlDbType.VarChar;
            //    ParCodigo.Size = 50;
            //    ParCodigo.Value = Articulo.Codigo;
            //    SqlCmd.Parameters.Add(ParCodigo);

            //    SqlParameter ParNombre = new SqlParameter();
            //    ParNombre.ParameterName = "@nombre";
            //    ParNombre.SqlDbType = SqlDbType.VarChar;
            //    ParNombre.Size = 50;
            //    ParNombre.Value = Articulo.Nombre;
            //    SqlCmd.Parameters.Add(ParNombre);

            //    SqlParameter ParDescripcion = new SqlParameter();
            //    ParDescripcion.ParameterName = "@descripcion";
            //    ParDescripcion.SqlDbType = SqlDbType.VarChar;
            //    ParDescripcion.Size = 1024;
            //    ParDescripcion.Value = Articulo.Descripcion;
            //    SqlCmd.Parameters.Add(ParDescripcion);

            //    SqlParameter ParImagen = new SqlParameter();
            //    ParImagen.ParameterName = "@imagen";
            //    ParImagen.SqlDbType = SqlDbType.Image;
            //    ParImagen.Value = Articulo.Imagen;
            //    SqlCmd.Parameters.Add(ParImagen);

            //    SqlParameter ParIdcategoria = new SqlParameter();
            //    ParIdcategoria.ParameterName = "@idcategoria";
            //    ParIdcategoria.SqlDbType = SqlDbType.VarChar;
            //    ParIdcategoria.Value = Articulo.Idcategoria;
            //    SqlCmd.Parameters.Add(ParIdcategoria);

            //    SqlParameter ParIdpresentacion = new SqlParameter();
            //    ParIdpresentacion.ParameterName = "@idpresentacion";
            //    ParIdpresentacion.SqlDbType = SqlDbType.VarChar;
            //    ParIdpresentacion.Value = Articulo.Idpresentacion;
            //    SqlCmd.Parameters.Add(ParIdpresentacion);


            //    //Ejecutamos nuestro comando

            //    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


            //}
            //catch (Exception ex)
            //{
            //    rpta = ex.Message;
            //}
            //finally
            //{
            //    if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            //}
            //return rpta;
        }
        public static void eliminarArticulo(Articulo art)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Articulo where Idarticulo = @Idarticulo";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Idarticulo", art.idArticulo);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                con.Close();
            }
        }

        public static List<Articulo> ObtenerArticulos()
        {
            Articulo art;

            listaArticulos.Clear();

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                try
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
                        art.categoria = Categoria.ObtenerCategorias(elLectorDeDatos.GetInt32(4));
                        art.presentacion = Presentacion.ObtenerPresentaciones(elLectorDeDatos.GetInt32(5));

                        listaArticulos.Add(art);
                    }
                }
                catch (Exception ex )
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }

            return listaArticulos;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@codigo", this.codigo);
            SqlParameter p2 = new SqlParameter("@nombre", this.nombre);
            SqlParameter p3 = new SqlParameter("@descripcion", this.descripcion);
            SqlParameter p4 = new SqlParameter("@presentacion", this.presentacion.idPresentacion);
            SqlParameter p5 = new SqlParameter("@categoria", this.categoria.IDCategoria);

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
                SqlParameter p9 = new SqlParameter("@idarticulo", this.idArticulo);
                p9.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p9);
            }
            return cmd;

        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p9 = new SqlParameter("@idarticulo", this.idArticulo);
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p9);
            return cmd;
        }

        public static DataTable ObtenerArticulo()
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {

                con.Open();
                string tectoCMD = "select * from Articulo";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }

        }



        public static Articulo ObtenerArticulo(int id)
        {
            Articulo articulo = null;

            if (listaArticulos.Count == 0) Articulo.ObtenerArticulo();

            foreach (Articulo c in listaArticulos)
            {
                if (c.idArticulo == id)
                {
                    articulo = c;
                    break;
                }

            }
            return articulo;

            

        }

        public static void Eliminar(Articulo a)
        {
            listaArticulos.Remove(a);
        }

        public static List<Articulo> Obtener()
        {
            return listaArticulos;
        }

        public override string ToString()
        {
            return codigo + " " + nombre + " " + descripcion + " " + categoria + " " + presentacion;
        }
    }



    }


