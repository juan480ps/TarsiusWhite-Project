using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Articulo
    {
        public enum _categoria
        {
            ventaLibre,
            bajoReceta
        }

        public enum _presentacion
        {
            comprimido,
            pastillaBlanda,
            jarabe
        }
        
        private int idArticulo;
        private string codigo;
        private string nombre;
        private string descripcion;
        public _categoria categoria { get; set; }
        public _presentacion presentacion { get; set; }
        private string textoBuscar;

        public int Idarticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string TextoBuscar
        {
            get { return textoBuscar; }
            set { textoBuscar = value; }
        }

        public Articulo()
        {

        }

        public static List<Articulo> listaArticulos = new List<Articulo>();

        public static void agregarArticulo(Articulo art)
        {
            listaArticulos.Add(art);
        }

        public static void editarArticulo(Articulo art, int indice)
        {
            Articulo.listaArticulos[indice] = art;
        }
        public static void eliminarArticulo(Articulo art)
        {
            listaArticulos.Remove(art);
        }

        public static List<Articulo> ObtenerArticulos()
        {
            return listaArticulos;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
