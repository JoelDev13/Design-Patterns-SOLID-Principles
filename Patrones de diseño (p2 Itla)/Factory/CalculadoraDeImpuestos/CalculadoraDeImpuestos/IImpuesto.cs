using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpuestos
{
    public interface IImpuesto
    {
        decimal CalcularImpuesto(decimal monto);
        decimal PorcentajeImpuesto { get; }
    }
}
