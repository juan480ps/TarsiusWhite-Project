using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public interface iPresentacion
    {
        string tipoPresentacion { get; set; }
        void obtenerPresentacion();
    }
}
