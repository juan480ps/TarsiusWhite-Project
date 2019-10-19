using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Presentacion : Articulo, iPresentacion
    {
        public int IdPresentacion { get; set; }
        public string NombrePresentacion { get; set; }
        public string DescripcionPresentacion { get; set; }
        string iPresentacion.tipoPresentacion { get; set; }

        public void obtenerPresentacion()
        {
           
        }
    }
}
