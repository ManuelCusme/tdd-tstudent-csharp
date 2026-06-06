namespace TStudent.Core;
using System;
internal static class Validaciones
{
    internal static void ValidarMuestra(double[] datos, string nombreParametro)
    {
        if (datos == null)
            throw new ArgumentNullException(nombreParametro, "La muestra no puede ser nula.");
        if (datos.Length < 2)
            throw new ArgumentException("La muestra debe tener al menos dos datos.", nombreParametro);
    }
}