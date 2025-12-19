using GestionDeUsuario;

public class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Crear un usario");
        Console.WriteLine("eija una opcion");
        Console.WriteLine("Empleado");
        Console.WriteLine("Cliente");
        Console.WriteLine("proveedores");
        String Sinfo = Console.ReadLine();
           

        IInformacion iUsuario = InformacionFactory.CrearInformacion(Sinfo);


        if (iUsuario != null)
        {
            iUsuario.Usuario();
        }
        else
        {
            Console.WriteLine("Error: No se pudo crear la información del usuario");
        }


    }
}