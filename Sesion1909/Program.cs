using Sesion1909.Ejercicio2;
using Sesion1909.Ejercicio3;
using Sesion1909.Ejercicio4;
using Sesion1909.Ejercicio5;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== Ejercicio 2: Dispositivos multimedia ===");
Dispositivo[] dispositivos =
[
    new SmartTv { Marca = "Samsung", Resolucion = "4K" },
    new ParlanteInteligente { Marca = "Sonos", PotenciaWatts = 50 }
];
foreach (Dispositivo dispositivo in dispositivos)
{
    dispositivo.ReproducirMedia();
}

Console.WriteLine("\n=== Ejercicio 3: Autonomía vehicular ===");
Vehiculo[] vehiculos =
[
    new Automovil { LitrosCombustible = 40, NumeroPuertas = 4 },
    new Camion { LitrosCombustible = 100, CapacidadCargaTon = 10 }
];
foreach (Vehiculo vehiculo in vehiculos)
{
    Console.WriteLine($"{vehiculo.GetType().Name}: {vehiculo.CalcularAutonomiaKm():F2} km de autonomía.");
}

Console.WriteLine("\n=== Ejercicio 4: Notificaciones ===");
Notificacion[] notificaciones =
[
    new CorreoElectronico { DireccionCorreo = "soporte@example.com", Mensaje = "Servidor fuera de servicio." },
    new Sms { NumeroTelefono = "+502 0000 0000", Mensaje = "Alerta: revisar el servidor." }
];
foreach (Notificacion notificacion in notificaciones)
{
    notificacion.Enviar();
}

Console.WriteLine("\n=== Ejercicio 5: Intereses bancarios ===");
CuentaBancaria[] cuentas =
[
    new CuentaAhorros { Saldo = 5000m, TasaPromocional = 0.01m },
    new CuentaInversion { Saldo = 20000m, FactorRiesgo = 1.2 }
];
// Cada mes se calcula y abona el interes al saldo, produciendo acumulacion.
for (int mes = 1; mes <= 2; mes++)
{
    Console.WriteLine($"Mes {mes}:");
    foreach (CuentaBancaria cuenta in cuentas)
    {
        decimal interes = cuenta.CalcularInteresMensual();
        cuenta.Saldo += interes;
        Console.WriteLine($"{cuenta.GetType().Name}: interés {interes:F2}; saldo actualizado {cuenta.Saldo:F2}.");
    }
}
