using Ejercio.Interfaz;

namespace Ejercio.Clases
{
    public class Carne : IComida
    {
        public void Comer()
        {
            Console.WriteLine("El gato come carne");
        }
    }
}
