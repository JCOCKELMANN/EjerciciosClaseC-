namespace Sesion1909.Ejercicio2;

public abstract class Dispositivo
{
    public string Marca { get; set; } = string.Empty;

    public abstract void ReproducirMedia();
}

public class SmartTv : Dispositivo
{
    public string Resolucion { get; set; } = string.Empty;

    public override void ReproducirMedia()
    {
        Console.WriteLine($"Smart TV {Marca}: reproduciendo video en {Resolucion}.");
    }
}

public class ParlanteInteligente : Dispositivo
{
    public int PotenciaWatts { get; set; }

    public override void ReproducirMedia()
    {
        Console.WriteLine($"Parlante {Marca}: reproduciendo audio con {PotenciaWatts} W de potencia.");
    }
}
