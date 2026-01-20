/* video todo code: https://youtu.be/UekxC1hvurk?si=OW83ltVUojr55ySA
    refactoring.guru: https://refactoring.guru/es/design-patterns/singleton
*/

namespace Ejercicio1
{
    public class Configuracion
    {
        //Variable estatica
        private static Configuracion instancia;

        //Constructor privado
        private Configuracion()
        {
            Console.WriteLine("Inicializando config en el sistema");
        }

        //Metodo público estático
        public static Configuracion GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Configuracion();
            }
            return instancia;
        }

        // Metodo del singleton
        public void MostrarMsg()
        {
            Console.WriteLine("Config activa");
        }
    }
}
