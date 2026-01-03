using SinLSP;

class program
{
    static void Main(string[] args)
    {
        // Creamos empleados
        Empleado emp1 = new EmpleadoTiempoCompleto
        {
            Nombre = "Joel",
            SalarioPorHora = 20
        };

        Empleado emp2 = new Voluntario
        {
            Nombre = "Johanna"
        };

        // Procesamos empleados en un array
        Empleado[] empleados = { emp1, emp2 };

        foreach (var empleado in empleados)
        {
            try
            {
                empleado.MostrarInfo(160);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        Console.WriteLine("PROBLEMA:");
        Console.WriteLine("No podemos usar Voluntario donde se espera Empleado");

        Console.ReadKey();
    }
}