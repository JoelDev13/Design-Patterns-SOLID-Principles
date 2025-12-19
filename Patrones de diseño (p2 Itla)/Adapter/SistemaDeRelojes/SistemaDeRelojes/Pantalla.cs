using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelojes
{
    public class Pantalla
    {
        public void MostrarHora(IReloj reloj)
        {
            reloj.MostrarDatos();
        }
    }
}
