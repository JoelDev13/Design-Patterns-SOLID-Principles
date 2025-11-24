using Ejercio.Interfaz;

namespace Ejercio.Clases
{
    public class Pescado : IComida
    {
        public void Comer()
        {
            Console.WriteLine("El gato come pescado");
        }
    }
}
