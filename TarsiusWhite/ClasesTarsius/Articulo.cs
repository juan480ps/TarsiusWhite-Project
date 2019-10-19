using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Articulo : Categoria
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
        private byte[] imagen;
        private int categoria;
        private int presentacion;
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
        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int Presentacion
        {
            get { return presentacion; }
            set { presentacion = value; }
        }
        public string TextoBuscar
        {
            get { return textoBuscar; }
            set { textoBuscar = value; }
        }

        //Constructores
        public Articulo()
        {

        }

        public Articulo(int idarticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion, string textobuscar)
        {
            this.Idarticulo = idarticulo;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
            this.Categoria = idcategoria;
            this.Presentacion = idpresentacion;
            this.TextoBuscar = textobuscar;
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
