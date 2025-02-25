using System;
using System.Diagnostics.Contracts;
class Program
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, int codigo, double precio)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
        }
    }

    public class Tienda
    {
        public void MostrarProducto(string Nombre, int Codigo, double Precio)
        {
            Console.WriteLine("El nombre del producto es " + Nombre);
            Console.WriteLine("El codigo del profucto es " + Codigo);
            Console.WriteLine("El precio del producto es " + Precio);
        }

        public void AgregarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo del producto");
            int Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            double Precio = int.Parse(Console.ReadLine());
            Producto producto = new Producto(Nombre, Codigo, Precio);
        }

        public void CalcularPrecio(double Precio)
        {
            double precioTotal = 0;
            precioTotal += Precio;
            Console.WriteLine("El precio total es " + precioTotal);

        }
    }
    static void Main()
    {
        Producto pinguinos = new Producto("Pinguinos", 10105, 22);
        Producto cheetos = new Producto("Cheetos", 90489, 18);
        Producto fanta = new Producto("Fanta", 34560, 20);
        Producto paleta = new Producto("Paleta", 03689, 5);
        Producto cafe = new Producto("cafe", 28943, 35);

        Tienda tienda = new Tienda();

        tienda.MostrarProducto(pinguinos.Nombre, pinguinos.Codigo, pinguinos.Precio);
        tienda.MostrarProducto(cheetos.Nombre, cheetos.Codigo, cheetos.Precio);
        tienda.MostrarProducto(fanta.Nombre, fanta.Codigo, fanta.Precio);
        tienda.MostrarProducto(paleta.Nombre, paleta.Codigo, paleta.Precio);
        tienda.MostrarProducto(cafe.Nombre, cafe.Codigo, cafe.Precio);

        tienda.CalcularPrecio(pinguinos.Precio);
        tienda.CalcularPrecio(cheetos.Precio);
        tienda.CalcularPrecio(fanta.Precio);
        tienda.CalcularPrecio(paleta.Precio);
        tienda.CalcularPrecio(cafe.Precio);

        Console.WriteLine("Quiere agregar un producto?");
        string respuesta = Console.ReadLine().ToLower();
        if (respuesta == "si")
        {
            tienda.AgregarProducto();
        }
    }
}
