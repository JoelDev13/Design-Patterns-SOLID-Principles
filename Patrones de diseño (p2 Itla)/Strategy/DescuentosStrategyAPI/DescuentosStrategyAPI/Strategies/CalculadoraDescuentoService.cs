namespace DescuentosStrategyAPI.Strategies
{
    public class CalculadoraDescuentoService
    {
        private readonly IDescuentoStrategy _estrategia;

        public CalculadoraDescuentoService(IDescuentoStrategy estrategia)
        {
            _estrategia = estrategia;
        }

        public decimal Calcular(decimal monto)
        {
            return _estrategia.Aplicar(monto);
        }
    }
}
