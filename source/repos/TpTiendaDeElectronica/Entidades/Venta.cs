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
                if (cat.Categoria.ToString() == categoria)
                {
                    auxlista.listaProductos.Add(cat);
                }
            }

            return auxlista;
        }

        //Filtrar por precio
        public Venta FiltraPorPrecio(double precio, Venta venta)
        {
            Venta auxlista = new Venta();

            foreach (Productos pre in venta.listaProductos)
            {
                if (precio >= pre.Precio)
                {
                    auxlista.listaProductos.Add(pre);
                }
            }

            return auxlista;
        }

        //Buscar nombre
        public Venta BuscaPorNombre(string nombre, Venta venta)
        {
            Venta auxlista = new Venta();

            foreach (Productos cat in venta.listaProductos)
            {
                if (cat.Nombre == nombre)
                {
                    auxlista.listaProductos.Add(cat);
                }
            }

            return auxlista;
        }

        //Suma Total  la venta 
        public double CalcularTotal(Venta venta)
        {
            double total = 0;

            if( venta.listaProductos is not null && venta.listaProductos.Any())//se fija q contenga elementos
            {
                foreach(Productos p in venta.listaProductos)
                {
                    total += p.Precio;
                }
            }

            return total;
        }

        //Metodo credito
        public double CalcularPagoConCredito(double total)
        {
            double totalCredito = 0;
            
            if(total > 0)
            {
                totalCredito = total * 1.10;
            }

            return totalCredito;
        }

        //Metodo Listado de Venta








    }
}
