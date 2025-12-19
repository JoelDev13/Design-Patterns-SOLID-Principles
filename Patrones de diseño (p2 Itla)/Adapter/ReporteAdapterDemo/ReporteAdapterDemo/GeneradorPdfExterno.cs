using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteAdapterDemo
{
    public class GeneradorPdfExterno
    {
        public void CrearPDF(string texto)
        {
            Console.WriteLine($"PDF generado con contenido: {texto}");
        }
    }

}
