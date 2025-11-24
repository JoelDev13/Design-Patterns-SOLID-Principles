using Ejercio.Interfaz;

namespace Ejercio
{
    public class Gato
    {
        private IComida comida;   

        public Gato(IComida comida)
        {
            this.comida = comida;
        }

        public void Comer()
        {
            comida.Comer();   
        }
    }

}
