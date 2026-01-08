using SinISP.Interfaces;

namespace SinISP
{
    public class Robot : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("El robot trabaja");
        }

        public void Comer()
        {
            //El robot no come, pero esta obligado a implementar esto (error)
            throw new NotImplementedException();
        }
    }
}
