using Ejercio.Interface;

namespace Ejercio.Clases
{
   public class SwimNormally : ISwimBehavior
    {
        public void Swim() => Console.WriteLine("Nado en el agua");
    }
}
