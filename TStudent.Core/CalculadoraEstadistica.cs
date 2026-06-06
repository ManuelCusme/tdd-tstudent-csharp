namespace TStudent.Core;

using System;
using System.Linq;

public class CalculadoraEstadistica
{
    // --- Estadística descriptiva ---

    public double CalcularMedia(double[] datos)
    {
        Validaciones.ValidarMuestra(datos, nameof(datos));
        return datos.Average();
    }

    public double CalcularVarianza(double[] datos)
    {
        Validaciones.ValidarMuestra(datos, nameof(datos));
        double media = CalcularMedia(datos);
        return datos.Sum(d => Math.Pow(d - media, 2)) / (datos.Length - 1);
    }

    public double CalcularDesviacion(double[] datos)
    {
        Validaciones.ValidarMuestra(datos, nameof(datos));
        return Math.Sqrt(CalcularVarianza(datos));
    }

    // --- Pruebas de hipótesis ---

    public double CalcularTStudent(double[] datos, double mediaPoblacional)
    {
        Validaciones.ValidarMuestra(datos, nameof(datos));
        double media = CalcularMedia(datos);
        return (media - mediaPoblacional) / ErrorEstandar(datos);
    }

    public double CalcularTStudentDosMuestras(double[] muestra1, double[] muestra2)
    {
        Validaciones.ValidarMuestra(muestra1, nameof(muestra1));
        Validaciones.ValidarMuestra(muestra2, nameof(muestra2));
        double media1 = CalcularMedia(muestra1);
        double media2 = CalcularMedia(muestra2);
        return (media1 - media2) / ErrorEstandarWelch(muestra1, muestra2);
    }

    // --- Métodos privados de apoyo ---

    private double ErrorEstandar(double[] datos)
    {
        return CalcularDesviacion(datos) / Math.Sqrt(datos.Length);
    }

    private double ErrorEstandarWelch(double[] muestra1, double[] muestra2)
    {
        return Math.Sqrt(CalcularVarianza(muestra1) / muestra1.Length +
                         CalcularVarianza(muestra2) / muestra2.Length);
    }
}