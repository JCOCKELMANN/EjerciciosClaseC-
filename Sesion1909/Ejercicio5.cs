namespace Sesion1909.Ejercicio5;

public abstract class CuentaBancaria
{
    public decimal Saldo { get; set; }

    public abstract decimal CalcularInteresMensual();
}

public class CuentaAhorros : CuentaBancaria
{
    // Tasa mensual expresada como fraccion: 0.01m representa 1 %.
    public decimal TasaPromocional { get; set; }

    public override decimal CalcularInteresMensual()
    {
        return decimal.Round(Saldo * TasaPromocional, 2, MidpointRounding.AwayFromZero);
    }
}

public class CuentaInversion : CuentaBancaria
{
    public double FactorRiesgo { get; set; }

    public override decimal CalcularInteresMensual()
    {
        // Supuesto didactico: base mensual de 1 %, multiplicada por riesgo
        // y por 1.5 cuando el saldo alcanza 10,000 unidades monetarias.
        decimal factorMonto = Saldo >= 10000m ? 1.5m : 1m;
        decimal interes = Saldo * 0.01m * (decimal)FactorRiesgo * factorMonto;
        return decimal.Round(interes, 2, MidpointRounding.AwayFromZero);
    }
}
