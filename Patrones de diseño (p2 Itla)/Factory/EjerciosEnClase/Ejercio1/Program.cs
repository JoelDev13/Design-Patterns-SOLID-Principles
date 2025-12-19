using Ejercio1;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Seleccione el medio donde vive el animal:");
        Console.WriteLine("1. Aire");
        Console.WriteLine("2. Tierra");
        Console.WriteLine("3. Agua");
        Console.Write("Opción: ");

        string entrada = Console.ReadLine();

        int opcion;
        if (int.TryParse(entrada, out opcion))
        {
            IMedio animal = Factory.GetTipo(opcion);

            if (animal != null)
            {
                animal.MostrarMedio();
            }
            else
            {
                Console.WriteLine("Opcion no válida");
            }
        }
        
    }
}
