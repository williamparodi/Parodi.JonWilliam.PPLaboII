using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta : Productos
    {
        private List<Productos> listaProductos;
        private DateTime fechaActual;

        public Venta()
        {
            this.listaProductos = new List<Productos>();
            fechaActual = DateTime.Now;
        }

        public Venta(List<Productos> listaProductos) : this()
        {
            this.listaProductos = listaProductos;
        }

        public List<Productos> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }

        public string MostrarListaProductos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista de Productos: ");

            foreach(Productos p in listaProductos)
            {
                sb.AppendLine(p.MostrarProducto());
            }

            return sb.ToString();
        }
      
        public Venta FiltraPorCategoria(string categoria, Venta venta)
        {
            Venta auxlista = new Venta();

            foreach (Productos cat in venta.listaProductos)
            {
                if (cat.Categoria == categoria)
                {
                    auxlista.listaProductos.Add(cat);
                }
            }

            return auxlista;
        }

        //Filtrar por precio
        //Buscar nombre
        //Buscar por marca













    }
}
