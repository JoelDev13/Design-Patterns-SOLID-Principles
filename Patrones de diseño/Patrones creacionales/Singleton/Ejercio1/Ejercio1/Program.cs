using Ejercicio1;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("modulo de autenticacion");
        Configuracion config1 = Configuracion.GetInstancia();
        config1.MostrarMsg();

        Console.WriteLine("modulo de reportes");
        Configuracion config2 = Configuracion.GetInstancia();
        config1.MostrarMsg();
    }
}