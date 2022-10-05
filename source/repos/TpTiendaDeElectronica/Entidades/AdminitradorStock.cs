using System.Collections.Generic;

namespace Entidades
{
    public class AdminitradorStock : Venta
    {
        public AdminitradorStock() : base()
        {

        }
        public AdminitradorStock(List<Productos> listaProductos) : base(listaProductos)
        {
            
        }

        public Productos AgregarNombre(string nombre)
        {
            Productos producto = new Productos();

            if (!string.IsNullOrEmpty(nombre))
            {
                producto.Nombre = nombre;
            }
            return producto;
        }

        public List<Productos> ListaDeProductos
        {
            get { return this.listaProductos; }
            set { this.listaProductos = value; }
        }

        public Productos AgregarCantidad(string cantidad)
        {
            Productos producto = new Productos();
            int cantidadASumar = 0;

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (int.TryParse(cantidad, out cantidadASumar))
                {
                    producto.Cantidad = cantidadASumar;
                }
            }
            return producto;
        }

        public Productos AgregarPrecio(string precio)
        {
            Productos producto = new Productos();
            int precioASumar = 0;

            if (!string.IsNullOrEmpty(precio))
            {
                if (int.TryParse(precio, out precioASumar))
                {
                    producto.Precio = precioASumar;
                }
            }
            return producto;
        }

        public Productos AgregarDatosAProducto(string nombre, string cantidad, string precio,string categoria)
        {
            Productos producto = new Productos();

            producto = AgregarNombre(nombre);
            producto = AgregarCantidad(cantidad);
            producto = AgregarPrecio(precio);

            switch(categoria)
            {
                case "Mother":
                    producto.Categoria = ECategorias.Mother;
                    break;
                case "MicroProcesador":
                    producto.Categoria = ECategorias.Microprocesador;
                    break;
                case "Perisfericos":
                    producto.Categoria = ECategorias.Perisfericos;
                    break;
                case "Gabinete":
                    producto.Categoria = ECategorias.Gabinete;
                    break;
                case "Monitor":
                    producto.Categoria = ECategorias.Monitor;   
                    break;
                default:
                    break;
                    
            }
            
            return producto;
        }

        public void AgregarProductoAStock(Productos producto)
        {
            if (producto is not null)
            {
                this.ListaDeProductos.Add(producto);
            }
        }

        public  List<Productos> FiltrarCategoria(string categoria)
        {
            List<Productos> auxListStock = new List<Productos>();

            if(!string.IsNullOrEmpty(categoria))
            {
                foreach(Productos producto in this.listaProductos)
                {
                    if(producto.Categoria.ToString() == categoria)
                    {
                        auxListStock.Add(producto);
                    }
                }
            }

            return auxListStock;
        }

        public List<Productos> FiltrarPorPrecioMaximo(string precio)
        {
            List<Productos> auxListaStock = new List<Productos>();
            double precioAComparar;

            if(double.TryParse(precio,out precioAComparar))
            {
                foreach (Productos producto in auxListaStock)
                {
                    if (precioAComparar >= producto.Precio)
                    {
                        auxListaStock.Add(producto);
                    }
                }
            }
           
            return auxListaStock;
        }



    }
}
