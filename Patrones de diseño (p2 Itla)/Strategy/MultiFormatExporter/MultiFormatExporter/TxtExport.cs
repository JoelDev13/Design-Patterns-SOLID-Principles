using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormatExporter
{
    public class TxtExport : IExportStrategy
    {
        private string ruta;

        public TxtExport(string rutaBase)
        {
            ruta = rutaBase + ".txt";
        }

        public void Exportar(Persona persona)
        {
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                writer.WriteLine(persona.Nombre);
                writer.WriteLine(persona.Edad);
                writer.WriteLine(persona.Correo);
                writer.WriteLine("-----------------");
            }
            Console.WriteLine($"Guardando ruta....");
            Console.WriteLine($"Archivo generado exitosamente: Exportancion.Txt");
        }
    }
}
