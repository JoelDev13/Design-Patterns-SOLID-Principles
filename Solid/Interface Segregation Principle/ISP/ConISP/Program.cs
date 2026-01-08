using ConISP;

class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado();
        Robot robot = new Robot();

        empleado.Trabajar();
        empleado.Comer();

        robot.Trabajar();
    }
}
