using ConISP.Interfaces;

namespace ConISP
{
    public class Empleado : ITrabajar, IComer
    {
        public void Trabajar()
        {
            Console.WriteLine("El empleado trabaja");
        }

        public void Comer()
        {
            Console.WriteLine("El empleado come");
        }
    }
}
