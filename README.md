# TDD T-Student — C# con xUnit

Implementación del estadístico T-Student aplicando la metodología 
Test-Driven Development (TDD) en C# con .NET y xUnit.

Desarrollado como práctica académica.

## Estructura del proyecto

TStudentTDD/
├── TStudent.Core/     # Lógica estadística (CalculadoraEstadistica)
├── TStudent.Tests/    # Pruebas unitarias con xUnit
└── TStudent.App/      # Aplicación cliente de consola

## Métodos implementados

- `CalcularMedia` — Media aritmética muestral
- `CalcularVarianza` — Varianza muestral (corrección de Bessel, n-1)
- `CalcularDesviacion` — Desviación estándar muestral
- `CalcularTStudent` — Prueba t de Student para una muestra
- `CalcularTStudentDosMuestras` — Prueba t de Welch para dos muestras independientes

## Pruebas unitarias

8 pruebas en total cubriendo:
- Casos válidos con valores verificados manualmente
- Validación de muestra vacía
- Validación de muestra con un solo dato
- Validación de entrada nula
- Prueba de refactorización estructural

## Ciclo TDD aplicado

Cada método fue desarrollado siguiendo estrictamente:
1. RED — Prueba escrita antes que el código, falla por ausencia del método
2. GREEN — Código mínimo para que la prueba pase
3. REFACTOR — Mejora estructural sin alterar el comportamiento

## Ejecución

# Ejecutar pruebas
dotnet test TStudent.Tests/TStudent.Tests.csproj

# Ejecutar aplicación
dotnet run --project TStudent.App/TStudent.App.csproj

## Tecnologías

- C# / .NET 10
- xUnit
- LINQ
- Visual Studio Code
