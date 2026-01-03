namespace SinLSP
{
    public class Voluntario : Empleado
    {
        public override decimal CalcularSalario(int horas)
        {
            // Los voluntarios no cobran (error)
            throw new InvalidOperationException("Los voluntarios no reciben salario");
        }

        public override void MostrarInfo(int horas)
        {
            Console.WriteLine($"Voluntario: {Nombre}");
            Console.WriteLine($"Horas donadas: {horas}");
            Console.WriteLine("No recibe compensacion");
        }
    }
}
