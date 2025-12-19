using Practica2;
using System.Numerics;

class Program
{
    static void Main()
    {
        string opcion = "";
        var gestor = GestorMensaje.getInstance();

        while (opcion != "4")
        {
            Console.Clear();
            Console.WriteLine("=== Sistema Registro de Mensajes ===");
            Console.WriteLine("1. Informacion");
            Console.WriteLine("2. Advertencia");
            Console.WriteLine("3. Error");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opcion: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": gestor.InsertarMensaje("Informacion"); break;
                case "2": gestor.InsertarMensaje("Advertencia"); break;
                case "3": gestor.InsertarMensaje("Error"); break;
                case "4": Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opcion invalida"); break;
            }

            


            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}