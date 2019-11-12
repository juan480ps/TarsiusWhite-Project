using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Cliente
    {
        public enum _sexo
        {
            Femenino,
            Masculino
        }

        public enum _tipoDocumento
        {
            CI,
            DNI

        }

        private int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public _sexo sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public _tipoDocumento tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }



        public Cliente()
        {

        }

        public static List<Cliente> listaClientes= new List<Cliente>();

        public static void agregarCliente(Cliente cli)
        {
            listaClientes.Add(cli);
        }

        public static void editarCliente(Cliente cli, int indice)
        {
            Cliente.listaClientes[indice] = cli;
        }
        public static void eliminarCliente(Cliente cli)
        {
            listaClientes.Remove(cli);
        }

        public static List<Cliente> ObtenerClientes()
        {
            return listaClientes;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
