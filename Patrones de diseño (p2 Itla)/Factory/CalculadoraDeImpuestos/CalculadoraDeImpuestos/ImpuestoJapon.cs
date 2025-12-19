using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpuestos
{
    public class ImpuestoJapon : IImpuesto
    {
        public decimal PorcentajeImpuesto => 0.10m;
        public decimal CalcularImpuesto(decimal monto)
        {
            return monto * PorcentajeImpuesto;
        }
    }
}
