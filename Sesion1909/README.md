# Ejercicios de herencia y polimorfismo

Solución en C# de los ejercicios 2, 3, 4 y 5 de las imágenes.
Requiere el SDK de .NET 10. Ejecutar desde esta carpeta:

```powershell
dotnet run
```

Cada ejercicio tiene su propio archivo y espacio de nombres. Las clases base
son abstractas y sus clases derivadas implementan los métodos con `override`.
`Program.cs` recorre arreglos del tipo base: la implementación ejecutada depende
del objeto concreto, demostrando polimorfismo sin seleccionar tipos con `if`.
Se conservan los nombres y tipos de propiedades indicados en los diagramas.

## Supuestos para las fórmulas

Las imágenes no definen tasas, consumos ni umbrales. Estos valores son ejemplos
didácticos, no modelos financieros ni estimaciones reales de consumo.
Los ejemplos usan cantidades no negativas y factores de riesgo positivos.

- Automóvil: autonomía = litros × 15 km/L.
- Camión: consumo = 20 + 2 × capacidad en toneladas, en L/100 km;
  autonomía = litros / consumo × 100. Se usa la capacidad como aproximación
  de carga porque el diagrama no incluye la carga efectiva.
- Ahorros: interés = saldo × tasa promocional mensual; `0.01m` equivale al 1 %.
- Inversión: interés = saldo × 0.01 × factor de riesgo × factor por monto.
  El factor por monto es 1 para saldos inferiores a 10,000 y 1.5 desde 10,000.
- Los intereses se redondean a dos decimales y se abonan después del cálculo.
  El programa muestra dos meses para demostrar la acumulación.
- Las notificaciones y la reproducción multimedia se simulan en consola.

## Resultados de referencia

Con los datos de `Program.cs`, el automóvil tiene 600 km de autonomía y el camión
250 km. En el primer mes, ahorros genera 50.00 e inversión 360.00; en el segundo,
50.50 y 366.48, respectivamente. Los saldos finales son 5100.50 y 20726.48.
