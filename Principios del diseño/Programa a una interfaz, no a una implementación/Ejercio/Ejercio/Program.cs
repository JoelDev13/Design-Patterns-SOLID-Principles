using Ejercio.Clases;
using Ejercio;

class Program
{
    static void Main(string[] args)
    {
        Gato gato1 = new Gato(new Salchicha());
        gato1.Comer();

        Gato gato2 = new Gato(new Pescado());
        gato2.Comer();

        Gato gato3 = new Gato(new Carne());
        gato3.Comer();
    }
}
