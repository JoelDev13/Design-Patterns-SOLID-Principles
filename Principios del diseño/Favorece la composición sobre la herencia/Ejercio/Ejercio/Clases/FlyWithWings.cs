using Ejercio.Interface;

namespace Ejercio.Clases
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("Vuelo con mis alas");
    }
}
