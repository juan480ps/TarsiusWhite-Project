using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ClasesTarsius
{
      public class Proveedor
    {

        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public _sector sector { get; set; }
        public _tipodocumento tipodocumento { get; set; }
        public  string NroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        

        public enum _sector
        {
            Asuncion,
            GranAsuncion, 
            CDE,

        }

        public enum _tipodocumento
        {
            CI,
            DNI, 
            Otro,
        }
        public Proveedor proveedor;

        public List<Proveedor> listaproveedor = new List<Proveedor>();

        public static List<Proveedor> listaproveedores = new List<Proveedor>();

        public static void agregarproveedor(Proveedor pro)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "INSERT INTO Proveedor VALUES (@IdProveedor, @RazonSocial, @SectorComercial , @TipoDocumento, @NumeroDocumento , @Direccion , @Telefono, @Email)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = pro.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();


                foreach (Proveedor a in pro.listaproveedor)
                {
                    string textoCmd2 = "INSERT INTO Proveedor VALUES (@IdProveedor, @RazonSocial, @SectorComercial , @TipoDocumento, @NumeroDocumento , @Direccion , @Telefono, @Email)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);
                    cmd2 = pro.ObtenerParametros(cmd);
                    cmd2.ExecuteNonQuery();
                }
            }
        }

        

        public static void editarproveedor(Proveedor pro, int indice)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Proveedor SET IdProveedor = @IdProveedor, RazonSocial = @RazonSocial, SectorComercial = @SectorComercial ,  TipoDocumento =  @TipoDocumento, NumeroDocumento = @NumeroDocumento , Direccion =  @Direccion , Telefono = @Telefono, Email = @Email";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = pro.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }


        public static void eliminarproveedor(Proveedor pro)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Proveedor  where IdProveedor = @IdProveedor";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@IdProveedor", pro.IdProveedor);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public static List<Proveedor> ObtenerProveedor()
        {
            Proveedor pro;

            listaproveedores.Clear();

            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {
                try
                {
                    con.Open();
                    string tectoCMD = "select * from Proveedor";
                    SqlCommand cmd = new SqlCommand(tectoCMD, con);

                    SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                    while (elLectorDeDatos.Read())
                    {
                        pro = new Proveedor();
                        pro.IdProveedor = elLectorDeDatos.GetInt32(0);
                        pro.NroDocumento = elLectorDeDatos.GetString(1);
                        pro.Direccion = elLectorDeDatos.GetString(2);
                        pro.Email = elLectorDeDatos.GetString(3);
                        pro.RazonSocial = elLectorDeDatos.GetString(4);
                        pro.Telefono = elLectorDeDatos.GetString(5);
                        
                        pro.sector = (_sector)elLectorDeDatos.GetInt32(6);
                        pro.tipodocumento = (_tipodocumento)elLectorDeDatos.GetInt32(7);

                         listaproveedores.Add(pro);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }

            return listaproveedores;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@IdProveedor", this.IdProveedor);
            SqlParameter p2 = new SqlParameter("@RazonSocial", this.RazonSocial);
            SqlParameter p3 = new SqlParameter("@SectorComerial", this.sector);
            SqlParameter p4 = new SqlParameter("@TipoDocumento", this.tipodocumento);
            SqlParameter p5 = new SqlParameter("@NroDocumento", this.NroDocumento);
            SqlParameter p6 = new SqlParameter("@Direccion", this.Direccion);
            SqlParameter p7 = new SqlParameter("@Telefono", this.Telefono);
            SqlParameter p8 = new SqlParameter("@Email", this.Email);

            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.VarChar; 
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.VarChar;
            p8.SqlDbType = SqlDbType.VarChar;



            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;

        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p1 = new SqlParameter("@IdProveedor", this.IdProveedor);
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);
            return cmd;
        }

        public static DataTable obtenerproveedor()
        {
            using (SqlConnection con = new SqlConnection(Conexion.CADENA_CONEXION))
            {

                con.Open();
                string tectoCMD = "select * from Proveedor";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }

        }
        public static void Eliminar(Proveedor a)
        {
            listaproveedores.Remove(a);
        }

        public static List<Proveedor> Obtener()
        {
            return listaproveedores;
        }

        public override string ToString()
        {
            return IdProveedor + " " + RazonSocial + " " + sector + " " + Telefono + " " ;
        }


    }
}
