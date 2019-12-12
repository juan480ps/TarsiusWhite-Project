using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Categoria
    {
        public int IDCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }

        public static List<Categoria> lstCategoria = new List<Categoria>();

        public static void agregarCategoria(Categoria cat)
        {
           
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "INSERT INTO Categoria VALUES ( @NombreCategoria, @DescripcionCategoria )";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = cat.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            
            SqlParameter p1 = new SqlParameter("@NombreCategoria", this.NombreCategoria);
            SqlParameter p2 = new SqlParameter("@DescripcionCategoria", this.DescripcionCategoria);            

           
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;           

          
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);         

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;
        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)//, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@IdCategoria", this.IDCategoria);
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);
            return cmd;
        }

        public static void editarCategoria(Categoria cat, int indice)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Categoria SET NombreCategoria = @NombreCategoria, DescripcionCategoria = @DescripcionCategoria where IdCategoria = @IdCategoria";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = cat.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static void eliminarCategoria(Categoria cat)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string SENTENCIA_SQL = "delete from Categoria where IdCategoria = @IdCategoria";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@IdCategoria", cat.IDCategoria);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static List<Categoria> ObtenerCategoria()
        {
            //return lstCategoria;

            Categoria cat;

            lstCategoria.Clear();

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Categoria";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    cat = new Categoria();
                    cat.IDCategoria = elLectorDeDatos.GetInt32(0);
                    cat.NombreCategoria = elLectorDeDatos.GetString(1);
                    cat.DescripcionCategoria = elLectorDeDatos.GetString(2);                    

                    lstCategoria.Add(cat);
                }
            }

            return lstCategoria;
        }

        public override string ToString()
        {
            return this.NombreCategoria + " " + this.DescripcionCategoria;
        }
    }

    //cambios 

}  

