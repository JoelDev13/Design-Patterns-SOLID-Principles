using ReporteAdapterDemo;

public class Program
{
    public static void Main(string[] args)
    {
        IReporte reporte = new Adapter();
        reporte.Generar("Este es el contenido del reporte");
    }
}