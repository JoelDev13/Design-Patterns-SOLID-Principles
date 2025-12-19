using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelojes
{
    public class RelojAnaAdapter
    {
        public class RelojesAnaAdapter : IReloj
        {
            private RelojAnalogico _relojAnalogico;

            public RelojesAnaAdapter(RelojAnalogico relojAnalogico)
            {
                _relojAnalogico = relojAnalogico;
            }

            public void MostrarDatos()
            {
                int h = _relojAnalogico.ObtenerHora();
                int m = _relojAnalogico.ObtenerMinutos();
                int s = _relojAnalogico.ObtenerSegundos();
                Console.WriteLine($"Hora actual: {h:D2}:{m:D2}:{s:D2}");
            }
        }
    }
}
