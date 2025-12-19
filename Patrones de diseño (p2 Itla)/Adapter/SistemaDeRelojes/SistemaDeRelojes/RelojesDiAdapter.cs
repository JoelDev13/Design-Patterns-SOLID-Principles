using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelojes
{
   public class RelojesDiAdapter :IReloj
    {
        private RelojDigital _relojDigital;

        public RelojesDiAdapter(RelojDigital relojDigital)
        {
            _relojDigital = relojDigital;
        }

        public void MostrarDatos()
        {
            string hora = _relojDigital.ObtenerHoraActual();
            Console.WriteLine($"Hora actual: {hora}");
        }
    }
}
