using Ejercio.Interface;

namespace Ejercio.Clases
{
    public class CannotFly : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("No puedo volar");
    }
}
