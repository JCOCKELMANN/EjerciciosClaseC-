public class Estudiante
{
    public string? Nombre { get; set; }
    public double Nota { get; set; }

    public void EstadoAprobacion()
    {
        string estado = Nota >= 6.0 ? "Aprobado" : "Reprobado";

        Console.WriteLine("Estudiante");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Nota: {Nota:F1}");
        Console.WriteLine($"Estado: {estado}");
        Console.WriteLine("-------------------------");
    }
}
