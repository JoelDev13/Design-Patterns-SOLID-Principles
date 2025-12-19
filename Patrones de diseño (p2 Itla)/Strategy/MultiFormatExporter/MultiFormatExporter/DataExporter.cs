using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormatExporter
{
    internal class DataExporter
    {
        private IExportStrategy strategy;

        public void SetStrategy(IExportStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Export(Persona persona)
        {
            strategy.Exportar(persona);
        }

    }
}
