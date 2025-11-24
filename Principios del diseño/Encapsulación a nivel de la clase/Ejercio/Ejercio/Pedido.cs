namespace Ejercio
{
    public class Pedido
    {
        public double Monto { get; set; }
        public string Provincia { get; set; }

        private CalculadoraImpuestos calculadora = new CalculadoraImpuestos();

        public double Impuesto => calculadora.Calcular(Monto, Provincia);
    }

}
