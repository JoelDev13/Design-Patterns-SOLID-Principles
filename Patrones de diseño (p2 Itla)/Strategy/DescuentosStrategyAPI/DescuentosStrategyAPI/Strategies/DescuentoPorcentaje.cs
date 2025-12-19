namespace DescuentosStrategyAPI.Strategies
{
    public class DescuentoPorcentaje : IDescuentoStrategy
    {
        private readonly decimal _porcentaje;

        public DescuentoPorcentaje(decimal porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public decimal Aplicar(decimal monto)
        {
            var descuento = monto * (_porcentaje / 100);
            return Math.Max(0, monto - descuento);
        }
    }
}
