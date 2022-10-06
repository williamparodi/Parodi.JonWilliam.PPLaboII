using System.Collections.Generic;

namespace Entidades
{
    public class AdminitradorStock 
    {
        private List<Productos> listaProductos;
        private Productos producto;
        public AdminitradorStock() 
        {
            this.listaProductos = new List<Productos>();
        }
        public AdminitradorStock(List<Productos> listaProductos)
        {
            this.listaProductos = listaProductos;
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

        public Productos Productos
        {
            get { return this.producto; }
            set { this.producto = value; }
        }

        public Productos AgregarCantidad(string cantidad)
        {
            int cantidadASumar = 0;

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (int.TryParse(cantidad, out cantidadASumar))
                {
                    this.producto.Cantidad = cantidadASumar;
                }
            }
            return producto;
        }

        public Productos AgregarPrecio(string precio)
        {
            
            double precioASumar = 0;

            if (!string.IsNullOrEmpty(precio))
            {
                if (double.TryParse(precio, out precioASumar))
                {
                    this.producto.Precio = precioASumar;
                }
            }
            return producto;
        }

        public Productos AgregarDatosAProducto(string nombre, string cantidad, string precio,string categoria)
        {
            this.producto = AgregarNombre(nombre);
            this.producto = AgregarCantidad(cantidad);
            this.producto = AgregarPrecio(precio);

            switch(categoria)
            {
                case "Mother":
                    this.producto.Categoria = ECategorias.Mother;
                    break;
                case "MicroProcesador":
                    this.producto.Categoria = ECategorias.Microprocesador;
                    break;
                case "Perisfericos":
                    this.producto.Categoria = ECategorias.Perisfericos;
                    break;
                case "Gabinete":
                    this.producto.Categoria = ECategorias.Gabinete;
                    break;
                case "Monitor":
                    this.producto.Categoria = ECategorias.Monitor;   
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
                this.listaProductos.Add(producto);
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

        public List<Productos> HarcodearLista()
        {
            List<Productos> listaHardcodeada = new List<Productos>();
            Productos productos = new Productos(ECategorias.Microprocesador, "Ryzen 5", 55666, 75);
            Productos productos1 = new Productos(ECategorias.Mother, "Asus", 2323, 75);
            Productos productos2 = new Productos(ECategorias.Gabinete, "Terma", 65652, 75);
            Productos productos3 = new Productos(ECategorias.Microprocesador, "Ryzen 5", 9874, 95);
            listaHardcodeada.Add(productos);
            listaHardcodeada.Add(productos1);
            listaHardcodeada.Add(productos2);
            listaHardcodeada.Add(productos3);

            return listaHardcodeada;
            
        }

    }
}
