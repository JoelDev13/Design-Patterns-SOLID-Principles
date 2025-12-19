using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormatExporter
{
    internal class ExportStrategyFactory
    {
        public static IExportStrategy Crear(string opcion, string rutaBase)
        {
            if (opcion == "1")
            {
                return new TxtExport(rutaBase);
            }
            else if (opcion == "2")
            {
                return new JsonExport(rutaBase);
            }
            else if (opcion == "3")
            {
                return new CsvExport(rutaBase);
            }
            else
            {
                return null;
            }
        }
    }
}

