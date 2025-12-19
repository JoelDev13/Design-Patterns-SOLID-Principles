using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EjercioAdapter
{
    public class JsonDataReader : IDataReader
    {
        public string Ruta {  get; set; }
        public string ReadData()
        {
            try
            {
                string jsonContenido = File.ReadAllText(Ruta);
                JsonDocument.Parse(jsonContenido);
                return jsonContenido;
            }
            catch(Exception e) 
            {
                throw new NotImplementedException($"error a leer el archivo {e.Message}");
            }
            
        }
    }
}
