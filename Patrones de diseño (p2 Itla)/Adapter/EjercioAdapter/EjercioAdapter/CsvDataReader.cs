using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace EjercioAdapter
{
    public class CsvDataReader
    {
        public string GetCsv(string Ruta)
        {
            try
            {
                using var reader = new StreamReader(Ruta);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                var registros = csv.GetRecords<dynamic>();
                var lista = new List<Dictionary<string, object>>();

                foreach (var registro in registros)
                {
                    var dict = new Dictionary<string, object>();
                    foreach (var prop in (IDictionary<string, object>)registro)
                    {
                        dict[prop.Key] = prop.Value;
                    }
                    lista.Add(dict);
                }

                return JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo CSV: {ex.Message}");
            }
        }
    }
}

