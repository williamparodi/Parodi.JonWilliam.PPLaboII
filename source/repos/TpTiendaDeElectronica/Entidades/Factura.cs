using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Factura
    {
        static int numeroFactura = 0;
       
        public static string CrearFactura(List<Productos> listaDeCompras,Cliente cliente,DateTime fechaCompra)
        {
            Venta venta = new Venta();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Factura Numero : {numeroFactura++} Fecha : {fechaCompra}");
            sb.AppendLine($"Datos Cliente : {cliente.MostarCliente()}");
            sb.AppendLine(venta.MostrarListaProductos(listaDeCompras));
            sb.AppendLine("------------------------------------------");
            return sb.ToString();
        }
    }
}
