using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelojes
{
    public class RelojDigital
    {
        public string ObtenerHoraActual()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
