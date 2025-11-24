using Ejercio;

class Program
{
    static void Main(string[] args)
    {
        Pedido p = new Pedido();
        p.Monto = 1000;
        p.Provincia = "San pedro de macoris";

        Console.WriteLine("Impuesto: " + p.Impuesto);
    }
}
