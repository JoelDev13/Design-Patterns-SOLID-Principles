namespace DescuentosStrategyAPI.Strategies
{
    public interface IDescuentoStrategy
    {
        decimal Aplicar(decimal monto);
    }
}
