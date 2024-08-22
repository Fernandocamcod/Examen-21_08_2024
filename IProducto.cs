// Interfaz que define los miembros esenciales de un producto en el supermercado
public interface IProducto
{
    string Codigo { get; set; }  // Código único del producto
    string Nombre { get; set; }  // Nombre del producto
    decimal Precio { get; set; } // Precio del producto
    decimal Descuento { get; }   // Descuento calculado automáticamente según el precio

    // Método para mostrar la información completa del producto
    void MostrarInformacion();
}
