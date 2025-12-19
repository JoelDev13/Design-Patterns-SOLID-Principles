using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpuestos
{
    public class Exportador
    {
        private static string RutaArchivo = @"C:\Users\la\Desktop\Programacion\Itla\Programacion 2\CalculadoraDeImpuestos\CalculadoraDeImpuestos\registro_operaciones.txt";

        public static void RegistrarOperacion(string pais, decimal montoOriginal, decimal porcentaje, decimal impuestoDescontado, decimal montoFinal)
        {
            string linea = "[" + DateTime.Now + "] " +
                           "Pais: " + pais + ", " +
                           "Monto original: " + montoOriginal + ", " +
                           "Porcentaje: " + (porcentaje * 100) + " %, " +
                           "Descuento: " + impuestoDescontado + ", " +
                           "Monto final: " + montoFinal;

            File.AppendAllText(RutaArchivo, linea + Environment.NewLine);
        }
    }
}
