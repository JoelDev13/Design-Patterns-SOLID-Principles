using System;

public class UserManager
{
    public void CreateUser(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Error: nombre invalido");
            return;
        }

        Console.WriteLine($"Guardando usuario: {name}");

        Console.WriteLine($"Usuario {name} creado con éxito");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var manager = new UserManager();
        manager.CreateUser("Joel");
    }
}
