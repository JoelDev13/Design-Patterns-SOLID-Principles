using ConLSP;

class program
{
    static void Main(string[] args)
    {

        // Creamos trabajadores
        Trabajador trab1 = new EmpleadoRemunerado
        {
            Nombre = "Jose",
            SalarioPorHora = 25
        };

        Trabajador trab2 = new Voluntario
        {
            Nombre = "Ana"
        };

        // Procesamos trabajadores en un array
        Trabajador[] trabajadores = { trab1, trab2 };

        foreach (var trabajador in trabajadores)
        {
            trabajador.MostrarInfo(160);
            Console.WriteLine();
        }

        Console.WriteLine("El codigo respeta el Principio de Sustitucion de Liskov");

        Console.ReadKey();
    }
}
