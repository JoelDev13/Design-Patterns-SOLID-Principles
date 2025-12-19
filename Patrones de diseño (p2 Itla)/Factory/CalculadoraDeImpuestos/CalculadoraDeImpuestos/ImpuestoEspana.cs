using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpuestos
{
    public class ImpuestoEspana : IImpuesto
    {
        public decimal PorcentajeImpuesto => 0.21m;
        public decimal CalcularImpuesto(decimal monto)
        {
            return monto * PorcentajeImpuesto;
        }
    }
}
