
public class Persona
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }

    public void MostrarDatos()
    {
        Console.WriteLine("****************************************");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine("****************************************");
    }
}