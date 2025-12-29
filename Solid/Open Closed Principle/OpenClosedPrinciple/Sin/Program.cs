using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tipo de cliente (Regular, Premium, Vip):");
        string tipoCliente = Console.ReadLine().Trim().ToLower();

        Console.WriteLine("Monto de la compra:");
        double monto = double.Parse(Console.ReadLine());

        double total = CalcularTotal(tipoCliente, monto);

        Console.WriteLine($"Total final: {total}");
        Console.WriteLine("Pedido guardado en la base de datos");
    }

    static double CalcularTotal(string tipoCliente, double monto)
    {
        double descuento = 0;

        if (tipoCliente == "regular")
        {
            descuento = monto * 0.05;
        }
        else if (tipoCliente == "premium")
        {
            descuento = monto * 0.10;
        }
        else if (tipoCliente == "vip")
        {
            descuento = monto * 0.20;
        }

        return monto - descuento;
    }
}
