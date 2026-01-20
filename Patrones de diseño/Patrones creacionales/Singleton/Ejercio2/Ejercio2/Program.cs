using Ejercio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("modulo de login");
        SesionUsuario sesion1 = SesionUsuario.GetInstance();
        sesion1.UsuarioActivo();

        Console.WriteLine("modulo reportes");
        SesionUsuario sesion2 = SesionUsuario.GetInstance();
        sesion2.UsuarioActivo();

        Console.WriteLine(sesion1 == sesion2);


    }
}