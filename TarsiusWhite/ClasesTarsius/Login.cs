using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Login
   
    {
        private const string NombreArchivo = "log.txt";
        private const string Separador = ";";
        public static void EscribirLog(string TipoError, string Error)
        {
            using (StreamWriter w = File.AppendText(NombreArchivo))
            {
                string FechaHora = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToLongTimeString();
                string linea = FechaHora + Separador + TipoError + Separador + Error;
                w.WriteLine(linea);

            }


        }
    }
}
}
