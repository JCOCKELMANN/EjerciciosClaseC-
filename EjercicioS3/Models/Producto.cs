public class Producto
{
    public string? Nombre { get; set; }
    public double Precio { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine("Producto");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio:C2}");
        Console.WriteLine("-------------------------");
    }
}
