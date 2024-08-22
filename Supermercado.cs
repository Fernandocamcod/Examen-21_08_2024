using System;
using System.Collections.Generic;
using System.Linq;

// Clase que gestiona las operaciones sobre los productos en el supermercado
public class Supermercado
{
    private readonly Dictionary<string, IProducto> productos = new Dictionary<string, IProducto>();

    // Introduce un nuevo producto después de pedir los datos al usuario
    public void IntroducirProducto()
    {
        Console.Write("Ingrese el código del producto: ");
        string codigo = Console.ReadLine();

        if (productos.ContainsKey(codigo))
        {
            Console.WriteLine("Error: Ya existe un producto con este código.");
            return;
        }

        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
        {
            Console.WriteLine("Error: Precio inválido.");
            return;
        }

        IProducto nuevoProducto = new Producto(codigo, nombre, precio);
        productos[codigo] = nuevoProducto;
        Console.WriteLine("Producto introducido con éxito.");
    }

    // Elimina un producto basado en su código
    public void EliminarProducto(string codigo)
    {
        if (productos.Remove(codigo))
        {
            Console.WriteLine("Producto eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("Error: Producto no encontrado.");
        }
    }

    // Consulta y muestra el nombre y el precio de un producto basado en su código
    public void ConsultarProducto(string codigo)
    {
        if (productos.TryGetValue(codigo, out IProducto producto))
        {
            Console.WriteLine($"NOMBRE: {producto.Nombre}, PRECIO: {producto.Precio:C}");
        }
        else
        {
            Console.WriteLine("Error: Producto no encontrado.");
        }
    }

    // Modifica el precio de un producto basado en su código
    public void ModificarPrecio(string codigo, decimal nuevoPrecio)
    {
        if (productos.TryGetValue(codigo, out IProducto producto))
        {
            (producto as Producto).Precio = nuevoPrecio;
            Console.WriteLine("Precio modificado con éxito.");
        }
        else
        {
            Console.WriteLine("Error: Producto no encontrado.");
        }
    }

    // Muestra todos los productos con un precio menor al valor especificado
    public void MostrarProductosMenoresDe(decimal precioMaximo)
    {
        var productosFiltrados = productos.Values.Where(p => p.Precio < precioMaximo);
        foreach (var producto in productosFiltrados)
        {
            producto.MostrarInformacion();
        }
    }

    // Muestra todos los productos con un precio mayor al valor especificado
    public void MostrarProductosMayoresDe(decimal precioMinimo)
    {
        var productosFiltrados = productos.Values.Where(p => p.Precio > precioMinimo);
        foreach (var producto in productosFiltrados)
        {
            producto.MostrarInformacion();
        }
    }

    // Muestra todos los productos
    public void MostrarTodosLosProductos()
    {
        foreach (var producto in productos.Values)
        {
            producto.MostrarInformacion();
        }
    }
}
