using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MultiFormatExporter
{
    internal class JsonExport : IExportStrategy
    {
        private string ruta;

        public JsonExport(string rutaBase)
        {
            ruta = rutaBase + ".json";
        }

        public void Exportar(Persona persona)
        {
            string json = JsonSerializer.Serialize(persona, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, json);
            Console.WriteLine($"Guardando ruta....");
            Console.WriteLine($"Archivo generado exitosamente: Exportancion.Json");
        }
    }
}
