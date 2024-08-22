using System;

// Implementa la interfaz IProducto con la lógica específica de un producto
public class Producto : IProducto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    // Propiedad calculada para obtener el descuento basado en el precio
    public decimal Descuento
    {
        get
        {
            if (Precio > 90) return Precio * 0.50m;
            if (Precio > 50) return Precio * 0.30m;
            if (Precio > 15) return Precio * 0.25m;
            return Precio * 0.05m;
        }
    }

    // Constructor para inicializar un nuevo producto con sus datos básicos
    public Producto(string codigo, string nombre, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
    }

    // Muestra la información del producto en la consola
    public void MostrarInformacion()
    {
        Console.WriteLine($"CODIGO: {Codigo}, NOMBRE: {Nombre}, PRECIO: {Precio:C}, DESCUENTO: {Descuento:C}");
    }
}
