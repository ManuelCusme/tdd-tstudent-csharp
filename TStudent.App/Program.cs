using TStudent.Core;

var calc = new CalculadoraEstadistica();

Console.WriteLine("==============================================");
Console.WriteLine("   CALCULADORA ESTADÍSTICA T-STUDENT");
Console.WriteLine("==============================================\n");

double[] datos = { 2, 4, 4, 4, 5, 5, 7, 9 };
double[] muestra1 = { 5, 7, 5, 3, 5, 3, 3, 9 };
double[] muestra2 = { 8, 1, 4, 6, 6, 4, 1, 2 };
double[] datosT = { 10, 11, 12 };

Console.WriteLine($"Datos: [{string.Join(", ", datos)}]");
Console.WriteLine($"Media:              {Math.Round(calc.CalcularMedia(datos), 3)}");
Console.WriteLine($"Varianza muestral:  {Math.Round(calc.CalcularVarianza(datos), 3)}");
Console.WriteLine($"Desviación estánd.: {Math.Round(calc.CalcularDesviacion(datos), 3)}");

Console.WriteLine($"\nDatos T-Student: [{string.Join(", ", datosT)}], μ = 10");
Console.WriteLine($"T-Student (1 muestra):     {Math.Round(calc.CalcularTStudent(datosT, 10), 3)}");

Console.WriteLine($"\nMuestra 1: [{string.Join(", ", muestra1)}]");
Console.WriteLine($"Muestra 2: [{string.Join(", ", muestra2)}]");
Console.WriteLine($"T-Student (2 muestras):    {Math.Round(calc.CalcularTStudentDosMuestras(muestra1, muestra2), 3)}");

Console.WriteLine("\n==============================================");
