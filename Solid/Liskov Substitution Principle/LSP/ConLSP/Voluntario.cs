namespace ConLSP
{
    public class Voluntario : Trabajador
    {
        public override string ObtenerTipo()
        {
            return "Voluntario";
        }

        public override void MostrarInfo(int horas)
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo: {ObtenerTipo()}");
            Console.WriteLine($"Horas contribuidas: {horas}");
            Console.WriteLine("Compensacion: Ninguna");
        }
    }
}
