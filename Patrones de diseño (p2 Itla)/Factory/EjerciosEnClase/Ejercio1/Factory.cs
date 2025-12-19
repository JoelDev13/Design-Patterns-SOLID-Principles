using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio1
{
    public class Factory
    {
        public static IMedio GetTipo(int opcion)
        {

            if (opcion == 1)
               return new Ave();
            else if (opcion == 2)
                return new Cuadrupedo();
            else if (opcion == 3)
                return new Pez();
            else
                return null;
        }
    }
}
    

