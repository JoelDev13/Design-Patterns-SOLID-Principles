using Ejercio.Interface;

namespace Ejercio
{
    public class Bird
    {
        private readonly IFlyBehavior _flyBehavior;
        private readonly ISwimBehavior _swimBehavior;

        public Bird(IFlyBehavior flyBehavior, ISwimBehavior swimBehavior)
        {
            _flyBehavior = flyBehavior;
            _swimBehavior = swimBehavior;
        }

        public void PerformFly() => _flyBehavior.Fly();
        public void PerformSwim() => _swimBehavior.Swim();
    }
}
