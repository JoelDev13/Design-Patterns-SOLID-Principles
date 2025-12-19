using System;
using System.Globalization;

namespace CalculadoraDeImpuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Calculadora de Impuestos ===");
                Console.WriteLine("Seleccione un pais:");
                Console.WriteLine("1. Republica Dominicana");
                Console.WriteLine("2. Japon");
                Console.WriteLine("3. Espana");
                Console.Write("Opcion (1-3): ");
                string opcion = Console.ReadLine();

                string pais = opcion switch
                {
                    "1" => "RD",
                    "2" => "Japon",
                    "3" => "Espana",
                    _ => null
                };

                if (pais == null)
                {
                    Console.WriteLine("Opcion invalida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Ingrese el monto: ");
                string entradaMonto = Console.ReadLine();

                if (!decimal.TryParse(entradaMonto, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal monto) || monto <= 0)
                {
                    Console.WriteLine("Monto invalido. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                IImpuesto impuesto = Factory.CrearImpuesto(pais);
                decimal impuestoCalculado = impuesto.CalcularImpuesto(monto);
                decimal montoFinal = monto - impuestoCalculado;

                Console.WriteLine();
                Console.WriteLine("Pais seleccionado: " + pais);
                Console.WriteLine("Monto ingresado: " + monto);
                Console.WriteLine($"Impuesto aplicado ({impuesto.PorcentajeImpuesto * 100} %): {impuestoCalculado}");
                Console.WriteLine("Monto final con descuento: " + montoFinal);

                Exportador.RegistrarOperacion(pais, monto, impuesto.PorcentajeImpuesto, impuestoCalculado, montoFinal);

                Console.WriteLine();
                Console.WriteLine("Operacion registrada");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}


