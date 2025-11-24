namespace Ejercios
{
    public class Auto
    {

        public void encender()
        {
            verificarSistema();
            activarMotor();
            Console.WriteLine("Auto encendido");

        }

        public void apagar()
        {
            Console.WriteLine("Auto apagado");
        }

        // Metodos privados solo se usan dentro de la clase
        private void activarMotor()
        {
            Console.WriteLine("Motor activado");
        }

        private void verificarSistema()
        {
            Console.WriteLine("Sistema verificado");
        }
    }

}
