namespace ConLSP
{
    public abstract class Trabajador
    {
        public string Nombre { get; set; }

        public abstract void MostrarInfo(int horas);
        public abstract string ObtenerTipo();
    }
}
