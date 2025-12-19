
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpuestos
{
    public class Factory 
    {
        public static IImpuesto CrearImpuesto(string pais)
        {
            return pais switch
            {
                "Japon" => new ImpuestoJapon(),
                "Espana" => new ImpuestoEspana(),
                "RD" => new ImpuestoRD(),
                _ => throw new ArgumentException("Pais no soportado")
            };
        }
    }
}

