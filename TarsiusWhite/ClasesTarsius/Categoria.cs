using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTarsius
{
    public class Categoria
    {
       public string IDCategoria;
       public  string NombreCategoria;
       public string DescripcionCategoria;





        public Categoria()
        {

        }

        public static List<Categoria> lstCategoria = new List<Categoria>();

        public static void agregarCategoria(Categoria cat)
        {
            lstCategoria.Add(cat);
        }

        public static void editarCategoria(Categoria cat, int indice)
        {
            Categoria.lstCategoria[indice] = cat;
        }

        public static void eliminarCategoria(Categoria cat)
        {
            lstCategoria.Remove(cat);
        }

        public static List<Categoria> ObtenerCategoria()
        {
            return lstCategoria;
        }

        public override string ToString()
        {
            return this.DescripcionCategoria;
        }
    }



}  

