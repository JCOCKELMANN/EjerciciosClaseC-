namespace Sesion1909.Ejercicio3;

public abstract class Vehiculo
{
    public double LitrosCombustible { get; set; }

    public abstract double CalcularAutonomiaKm();
}

public class Automovil : Vehiculo
{
    public int NumeroPuertas { get; set; }

    public override double CalcularAutonomiaKm()
    {
        // Supuesto didactico: el automovil recorre 15 km por litro.
        return LitrosCombustible * 15;
    }
}

public class Camion : Vehiculo
{
    public double CapacidadCargaTon { get; set; }

    public override double CalcularAutonomiaKm()
    {
        // Supuesto didactico: 20 L/100 km mas 2 L por tonelada de capacidad.
        double consumoLitrosPor100Km = 20 + 2 * CapacidadCargaTon;
        return LitrosCombustible / consumoLitrosPor100Km * 100;
    }
}
