using Con_ocp.Class;
using Con_ocp.Interfaces;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tipo de cliente (Regular, Premium, Vip):");
        string tipoCliente = Console.ReadLine().Trim().ToLower();

        Console.WriteLine("Monto de la compra:");
        decimal monto = decimal.Parse(Console.ReadLine());

        IDescuento descuento = CalcularTotal(tipoCliente);
        decimal total = monto - descuento.Calcular(monto);

        Console.WriteLine($"Total final: {total}");

    }

    static IDescuento CalcularTotal(string tipo)
    {
        return tipo switch
        {
            "regular" => new Regular(),
            "premium" => new Premium(),
            "vip" => new Vip(),
            _ => throw new Exception("Tipo de cliente invalido")
        };
    }
}
