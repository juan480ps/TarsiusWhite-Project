using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    class Empleado
    {
        public enum _sexo
        {
            Femenino,
            Masculino,
        }

        private int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public _sexo sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string nroDocumento { get; set; }
        public string direccion { get; set; }
        public  string telefono { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }



        public Empleado()
        {

        }

        public static List<Empleado> listaEmpleados = new List<Empleado>();

        public static void agregarEmpleado(Empleado emp)
        {
            listaEmpleados.Add(emp);
        }

        public static void editarEmpleado(Empleado emp, int indice)
        {
            Empleado.listaEmpleados[indice] = emp;
        }
        public static void eliminarEmpleado(Empleado emp)
        {
            listaEmpleados.Remove(emp);
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            return listaEmpleados;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}


       




    }
}
