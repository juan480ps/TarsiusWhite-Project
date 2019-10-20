using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Presentacion //: Articulo, iPresentacion
    {
        //las primeras letras de la variables deben ir en minusculas
        public int IdPresentacion { get; set; }
        public string NombrePresentacion { get; set; }
        public string DescripcionPresentacion { get; set; }
        //string iPresentacion.tipoPresentacion { get; set; }

        //public void obtenerPresentacion()
        //{
           
        //}
        public Presentacion()
        {

        }

        public static List<Presentacion> listaPresentacion = new List<Presentacion>();

        public static void agregarPresentacion(Presentacion pre)
        {
            listaPresentacion.Add(pre);
        }

        public static void editarPresentacion(Presentacion pre, int indice)
        {
            Presentacion.listaPresentacion[indice] = pre;
        }
        public static void eliminarPresentacion(Presentacion pre)
        {
            listaPresentacion.Remove(pre);
        }

        public static List<Presentacion> ObtenerPresentacion()
        {
            return listaPresentacion;
        }
//checkar esto
    }
}
