namespace Ejercio2
{
    public  class SesionUsuario
    {

        private static SesionUsuario instance;

        private SesionUsuario() {
            Console.WriteLine("[SISTEMA] Sesión de usuario inicializada");
        }

        public static SesionUsuario GetInstance()
        {
            if (instance == null)
            {
                instance = new SesionUsuario();
            }
            return instance;
        }

        public void UsuarioActivo()
        {
            Console.WriteLine($"[SISTEMA] Sesión de usuario activa");
        }
    }
}
