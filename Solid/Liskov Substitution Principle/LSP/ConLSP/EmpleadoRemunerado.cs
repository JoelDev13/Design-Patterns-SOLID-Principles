namespace ConLSP
{
    public class EmpleadoRemunerado : Trabajador
    {
        public decimal SalarioPorHora { get; set; }

        public decimal CalcularSalario(int horas)
        {
            return SalarioPorHora * horas;
        }

        public override string ObtenerTipo()
        {
            return "Empleado Remunerado";
        }

        public override void MostrarInfo(int horas)
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo: {ObtenerTipo()}");
            Console.WriteLine($"Horas trabajadas: {horas}");
            Console.WriteLine($"Salario: ${CalcularSalario(horas)}");
        }
    }
}
