namespace DescuentosStrategyAPI.Strategies
{
    public class DescuentoNinguno : IDescuentoStrategy
    {
        public decimal Aplicar(decimal monto)
        {
            return monto;
        }
    }
}
