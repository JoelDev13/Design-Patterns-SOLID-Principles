using Ejercio.Clases;
using Ejercio;

class Program
{
    static void Main(string[] args) { 

    Console.WriteLine("Gorrion:");
        var sparrow = new Bird(
            new FlyWithWings(),
            new CannotSwim()
        );
        
        sparrow.PerformFly();
        sparrow.PerformSwim();

        Console.WriteLine("Pinguino:");
        var penguin = new Bird(
            new CannotFly(),
            new SwimNormally()
        );
        
        penguin.PerformFly();
        penguin.PerformSwim();

        Console.ReadKey();

    }
}