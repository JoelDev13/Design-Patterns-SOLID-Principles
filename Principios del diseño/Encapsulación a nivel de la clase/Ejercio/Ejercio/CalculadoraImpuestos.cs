namespace Ejercio
{
    public class CalculadoraImpuestos
    {
        public double Calcular(double monto, string provincia)
        {
            return provincia switch
            {
                "San pedro de macoris" => monto * 0.21,
                "Higuey" => monto * 0.18,
                "Azua" => monto * 0.10,
                _ => 0
            };
        }
    }

}
