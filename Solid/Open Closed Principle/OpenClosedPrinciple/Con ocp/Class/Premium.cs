using Con_ocp.Interfaces;

namespace Con_ocp.Class
{
    public class Premium : IDescuento
    {
        public decimal Calcular(decimal monto)
        {
            return monto * 0.10m;
        }
    }
}
