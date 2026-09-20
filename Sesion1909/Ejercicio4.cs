namespace Sesion1909.Ejercicio4;

public abstract class Notificacion
{
    public string Mensaje { get; set; } = string.Empty;

    public abstract void Enviar();
}

public class CorreoElectronico : Notificacion
{
    public string DireccionCorreo { get; set; } = string.Empty;

    public override void Enviar()
    {
        Console.WriteLine($"Correo simulado para {DireccionCorreo}: {Mensaje}");
    }
}

public class Sms : Notificacion
{
    public string NumeroTelefono { get; set; } = string.Empty;

    public override void Enviar()
    {
        Console.WriteLine($"SMS simulado para {NumeroTelefono}: {Mensaje}");
    }
}
