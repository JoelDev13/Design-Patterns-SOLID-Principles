using SistemaDeRelojes;
using static SistemaDeRelojes.RelojAnaAdapter;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Relojes ===");
        Console.WriteLine("Seleccione el tipo de reloj:");
        Console.WriteLine("1. Digital");
        Console.WriteLine("2. Analógico");
        Console.Write("> ");

        string opcion = Console.ReadLine();
        IReloj reloj = null;
        Pantalla pantalla = new Pantalla();

        switch (opcion)
        {
            case "1":
                RelojDigital relojDigital = new RelojDigital();
                reloj = new RelojesDiAdapter(relojDigital);
                break;

            case "2":
                Console.Write("Ingrese la hora (0-23): ");
                int hora = int.Parse(Console.ReadLine());

                Console.Write("Ingrese los minutos (0-59): ");
                int minutos = int.Parse(Console.ReadLine());

                Console.Write("Ingrese los segundos (0-59): ");
                int segundos = int.Parse(Console.ReadLine());

                RelojAnalogico relojAnalogico = new RelojAnalogico(hora, minutos, segundos);
                reloj = new RelojesAnaAdapter(relojAnalogico);
                break;

            default:
                Console.WriteLine("Opción inválida.");
                return;
        }

        pantalla.MostrarHora(reloj);
    }

}
