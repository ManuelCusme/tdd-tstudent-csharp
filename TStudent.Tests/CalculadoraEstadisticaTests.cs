namespace TStudent.Tests;

using System;
using TStudent.Core;
using Xunit;
public class CalculadoraEstadisticaTests
{
    private readonly CalculadoraEstadistica _calc = new CalculadoraEstadistica();
    [Fact]
    public void CalcularMedia_ConDatosValidos_RetornaMediaCorrecta()
    {
        double[] datos = { 1, 2, 3, 4, 5 };
        double resultado = _calc.CalcularMedia(datos);
        Assert.Equal(3.0, resultado);
    }
    [Fact]
    public void CalcularVarianza_ConDatosValidos_RetornaVarianzaCorrecta()
    {
        double[] datos = { 2, 4, 4, 4, 5, 5, 7, 9 };
        double resultado = _calc.CalcularVarianza(datos);
        Assert.Equal(4.571, Math.Round(resultado, 3));
    }
    [Fact]
    public void CalcularDesviacion_ConDatosValidos_RetornaDesviacionCorrecta()
    {
        double[] datos = { 2, 4, 4, 4, 5, 5, 7, 9 };
        double resultado = _calc.CalcularDesviacion(datos);
        Assert.Equal(2.138, Math.Round(resultado, 3));
    }
    [Fact]
    public void CalcularTStudent_ConDatosValidos_RetornaEstadisticoCorrecto()
    {
        double[] datos = { 10, 11, 12 };
        double mediaPoblacional = 10;
        double resultado = _calc.CalcularTStudent(datos, mediaPoblacional);
        Assert.Equal(1.732, Math.Round(resultado, 3));
    }
    [Fact]
    public void CalcularTStudentDosMuestras_ConDatosValidos_RetornaEstadisticoCorrecto()
    {
        double[] muestra1 = { 5, 7, 5, 3, 5, 3, 3, 9 };
        double[] muestra2 = { 8, 1, 4, 6, 6, 4, 1, 2 };
        double resultado = _calc.CalcularTStudentDosMuestras(muestra1, muestra2);
        Assert.Equal(0.847, Math.Round(resultado, 3));
    }
    [Fact]
    public void CalcularMedia_ConMuestraVacia_LanzaExcepcion()
    {
        double[] datos = { };
        Assert.Throws<ArgumentException>(() => _calc.CalcularMedia(datos));
    }
    [Fact]
    public void CalcularMedia_ConUnSoloDato_LanzaExcepcion()
    {
        double[] datos = { 5 };
        Assert.Throws<ArgumentException>(() => _calc.CalcularMedia(datos));
    }
    [Fact]
    public void CalcularMedia_ConEntradaNula_LanzaExcepcion()
    {
        Assert.Throws<ArgumentNullException>(() => _calc.CalcularMedia(null));
    }
}