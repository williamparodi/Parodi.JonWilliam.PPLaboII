using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace TpTiendaDeElectronica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Productos> listadeProductos = new List<Productos>();
            double total = 0;
            double totalConCredito = 0;
            Productos listaProductos = new Productos(ECategorias.Microprocesador,"Ryzen 5",55666,75);
            Productos listaProductos1 = new Productos(ECategorias.Mother, "Asus",2323, 75);
            Productos listaProductos2 = new Productos(ECategorias.Gabinete, "Terma", 65652, 75);
            Productos listaProductos3 = new Productos(ECategorias.Microprocesador, "Ryzen 5", 9874, 95);

            listadeProductos.Add(listaProductos);
            listadeProductos.Add(listaProductos1);
            listadeProductos.Add(listaProductos2);
            listadeProductos.Add(listaProductos3);

            Venta nueva = new Venta(listadeProductos);
            Venta nueva2 = nueva.FiltraPorCategoria("Mother", nueva);
            Venta nueva3 = nueva.FiltraPorPrecio(3000, nueva);
            Venta nueva4 = nueva.BuscaPorNombre("Ryzen 5", nueva);
            total = nueva.CalcularTotal(listadeProductos);
            totalConCredito = nueva.CalcularPagoConCredito(total);

            Console.WriteLine(nueva.MostrarListaProductos());
            Console.WriteLine("Lista Filtrada: ");
            Console.WriteLine(nueva2.MostrarListaProductos());
            Console.WriteLine(nueva3.MostrarListaProductos());
            Console.WriteLine(nueva4.MostrarListaProductos());
            Console.WriteLine(total);
            Console.WriteLine(totalConCredito);
            
        }
    }
}
