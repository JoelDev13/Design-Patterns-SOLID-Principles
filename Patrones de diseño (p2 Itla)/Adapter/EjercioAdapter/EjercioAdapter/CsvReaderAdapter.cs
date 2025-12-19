using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercioAdapter
{
    public class CsvReaderAdapter : IDataReader
    {
        private readonly CsvDataReader _reader = new CsvDataReader();
        private readonly string _ruta;

        public CsvReaderAdapter(string ruta)
        {
            _ruta = ruta;
        }
        public string ReadData()
        {
            return _reader.GetCsv(_ruta);
        }
    }
}
