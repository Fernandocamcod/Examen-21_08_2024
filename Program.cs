using System;

class Program
{
    static void Main()
    {
        Supermercado supermercado = new Supermercado();

        // Introducir productos
        Console.WriteLine("Introduzca un nuevo producto:");
        supermercado.IntroducirProducto();

        Console.WriteLine("\nIntroduzca otro nuevo producto:");
        supermercado.IntroducirProducto();

        // Mostrar información de todos los productos
        Console.WriteLine("\nMostrar todos los productos:");
        supermercado.MostrarTodosLosProductos();

        // Consultar un producto
        Console.WriteLine("\nConsultar producto con código 002:");
        supermercado.ConsultarProducto("002");

        // Modificar el precio de un producto
        Console.WriteLine("\nModificar precio del producto con código 001 a 12:");
        supermercado.ModificarPrecio("001", 12m);

        // Mostrar productos con un precio menor a 30
        Console.WriteLine("\nMostrar productos con precio menor a 30:");
        supermercado.MostrarProductosMenoresDe(30m);

        // Mostrar productos con un precio mayor a 60
        Console.WriteLine("\nMostrar productos con precio mayor a 60:");
        supermercado.MostrarProductosMayoresDe(60m);

        // Eliminar un producto
        Console.WriteLine("\nEliminar producto con código 003:");
        supermercado.EliminarProducto("003");

        // Mostrar productos después de la eliminación
        Console.WriteLine("\nMostrar productos después de eliminación:");
        supermercado.MostrarTodosLosProductos();

        // Espera a que el usuario presione una tecla para cerrar la aplicación
        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}
