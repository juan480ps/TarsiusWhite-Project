using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class DetalleVenta
    {
        private int IdDetalleVenta { get; set; }
        public int cantidad { get; set; }
        public Articulo articulo { get; set; }
        public int PrecioVenta { get; set; }

    }
}