 using MultiFormatExporter;
using System;

class Program
{
    static void Main()
    {
        Persona persona = new Persona();

        Console.Write("Ingrese su nombre: ");
        persona.Nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        persona.Edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su correo electronico: ");
        persona.Correo = Console.ReadLine();

        Console.WriteLine("En que formato desea guardar los datos");
        Console.WriteLine("1. Texto (.txt)");
        Console.WriteLine("2. JSON (.json)");
        Console.WriteLine("3. CSV (.csv)");
        Console.Write("Opcion: ");
        string opcion = Console.ReadLine();

      
        string rutaBase = @"C:\Users\la\Desktop\Programacion\Mi roadmap backend\Patrones De Diseños c#\Strategy\MultiFormatExporter\MultiFormatExporter\Exportancion";

        IExportStrategy strategy = ExportStrategyFactory.Crear(opcion, rutaBase);

        if (strategy == null)
        {
            Console.WriteLine("Opcion invalida");
            return;
        }

        DataExporter exporter = new DataExporter();
        exporter.SetStrategy(strategy);
        exporter.Export(persona);
    }
}
