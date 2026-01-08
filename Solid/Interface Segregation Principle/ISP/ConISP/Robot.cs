using ConISP.Interfaces;

namespace ConISP
{
    public class Robot : ITrabajar
    {
        public void Trabajar()
        {
            Console.WriteLine("El robot trabaja");
        }
    }
}
