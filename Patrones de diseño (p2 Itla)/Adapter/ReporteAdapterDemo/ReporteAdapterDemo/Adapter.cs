using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteAdapterDemo
{
    public class Adapter : IReporte
    {
        GeneradorPdfExterno Genera = new GeneradorPdfExterno();

        public void Generar(string contenido)
        {
            Genera.CrearPDF(contenido);
        }
    }
}
