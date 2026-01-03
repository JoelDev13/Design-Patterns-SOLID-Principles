namespace SinLSP
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioPorHora { get; set; }

        public virtual decimal CalcularSalario(int horas)
        {
            return SalarioPorHora * horas;
        }
        
        public virtual void MostrarInfo(int horas)
        {
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"Salario por {horas} horas: ${CalcularSalario(horas)}");
        }
    }
}
