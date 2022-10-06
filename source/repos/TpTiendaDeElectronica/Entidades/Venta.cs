using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta 
    {
        protected List<Productos> listaProductos;

        public Venta() 
        {
            this.listaProductos = new List<Productos>();  
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

        public  string MostrarListaProductos()
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
        public double CalcularTotal(List<Productos> listaProductos)
        {
            double total = 0;

            if(listaProductos is not null && listaProductos.Any())//se fija q contenga elementos
            {
                foreach(Productos p in listaProductos)
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

        public bool ConfirmaVenta(List<Productos> listaVenta)
        {
            bool retorno = true;

            if(listaProductos is not null && listaProductos.Count>0)
            {
                foreach(Productos producto in listaVenta)
                {
                    if(producto.Cantidad <=0)
                    {
                        retorno = false;
                    }
                }
            }

            return retorno;
        }

        public double CalcularPago(string formaPago,List<Productos> listaCompras)
        {
            double subtotal = 0;
            double total = 0;

            if(formaPago != string.Empty && listaCompras is not null)
            {
                if (formaPago == "Credito")
                {
                    subtotal = CalcularTotal(listaCompras);
                    total = CalcularPagoConCredito(subtotal);
                }
                else if (formaPago == "Efectivo")
                {
                    total = CalcularTotal(listaCompras);
                }
            }

            return total;
        }
        
        public void DescontarUnidad(List<Productos> listaProductos,List<Productos> listaCompras)
        {
            if(listaProductos is not null && listaCompras is not null && listaProductos.Any() && listaCompras.Any())
            {
                if(ConfirmaVenta(listaCompras))
                {
                    foreach(Productos p in listaProductos)
                    {
                        if(listaCompras.Contains(p))//mmm probar
                        {
                            p.Cantidad--;
                        }
                    }
                }
            }
        }



    }
}
