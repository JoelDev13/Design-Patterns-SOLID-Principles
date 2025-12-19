namespace DescuentosStrategyAPI.Strategies
{
    public class DescuentoFijo : IDescuentoStrategy
    {
        private readonly decimal _valor;

        public DescuentoFijo(decimal valor)
        {
            _valor = valor;
        }

        public decimal Aplicar(decimal monto)
        {
            return Math.Max(0, monto - _valor);
        }
    }
}
