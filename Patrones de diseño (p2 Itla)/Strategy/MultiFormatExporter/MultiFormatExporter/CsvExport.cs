using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormatExporter
{
    internal class CsvExport : IExportStrategy
    {
        private string ruta;

        public CsvExport(string rutaBase)
        {
            ruta = rutaBase + ".csv";
        }

        public void Exportar(Persona persona)
        {
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                writer.WriteLine("Nombre,Edad,Correo");
                writer.WriteLine($"{persona.Nombre},{persona.Edad},{persona.Correo}");
            }
            Console.WriteLine($"Guardando ruta....");
            Console.WriteLine($"Archivo generado exitosamente: Exportancion.Csv");
        }
    }
}
