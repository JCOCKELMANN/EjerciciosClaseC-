public class Carro
{
    public string? Marca { get; set; }
    public int Anio { get; set; }

    public void Arrancar()
    {
        Console.WriteLine("Carro");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Año: {Anio}");
        Console.WriteLine("El carro ha arrancado correctamente.");
        Console.WriteLine("-------------------------");
    }
}
