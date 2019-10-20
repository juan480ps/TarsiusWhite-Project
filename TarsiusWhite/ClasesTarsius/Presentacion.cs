using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static List<Presentacion> obtenerPresentacion()
        {
            return listaPresentacion;
        }

        public override string ToString()
        {
            return this.nombrePresentacion;
        }
    }
}
