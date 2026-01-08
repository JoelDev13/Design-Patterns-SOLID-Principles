using SinISP.Interfaces;

namespace SinISP
{
    public class Empleado : ITrabajador
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
