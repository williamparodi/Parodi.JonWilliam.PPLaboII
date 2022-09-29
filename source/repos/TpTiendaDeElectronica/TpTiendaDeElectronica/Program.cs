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
            

            Productos listaProductos = new Productos(EMarca.Redragon,"Mouse",55666,75);
            Productos listaProductos1 = new Productos(EMarca.Amd, "Procesador",2323, 75);
            Productos listaProductos2 = new Productos(EMarca.Intel, "Mother", 65652, 75);
            Productos listaProductos3 = new Productos(EMarca.Redragon, "Mother", 9874, 95);

            listadeProductos.Add(listaProductos);
            listadeProductos.Add(listaProductos1);
            listadeProductos.Add(listaProductos2);
            listadeProductos.Add(listaProductos3);

            Venta nueva = new Venta(listadeProductos);
            Venta nueva2 = nueva.FiltraPorCategoria("Mother", nueva);

            Console.WriteLine(nueva.MostrarListaProductos());
            Console.WriteLine("Lista Filtrada: ");
            
            Console.WriteLine(nueva2.MostrarListaProductos());
        }
    }
}
