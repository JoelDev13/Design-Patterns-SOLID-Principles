using Ejercio.Interface;

namespace Ejercio.Clases
{
    public class CannotSwim : ISwimBehavior
    {
        public void Swim() => Console.WriteLine("No puedo nadar");
    }
}
