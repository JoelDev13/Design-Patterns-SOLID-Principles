using PRACTICA1;

class Program
{

    static List<Libro> libros = new();
    static List<Usuario> usuarios = new();
    static List<Prestamo> prestamos = new();
    static Bitacora bitacora = new();

    static void Main()
    {
        string opcion = "";
        while (opcion != "5")
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Biblioteca ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Registrar usuario");
            Console.WriteLine("3. Realizar préstamo");
            Console.WriteLine("4. Mostrar bitácora");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": AgregarLibro(); break;
                case "2": RegistrarUsuario(); break;
                case "3": RealizarPrestamo(); break;
                case "4": bitacora.MostrarEventos(); break;
                case "5": Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción inválida"); break;
            }

            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void AgregarLibro()
    {
        Console.Write("Título: ");
        var titulo = Console.ReadLine();
        Console.Write("Autor: ");
        var autor = Console.ReadLine();
        libros.Add(new Libro(titulo, autor));
        bitacora.RegistrarEvento($"Libro '{titulo}' agregado.");
    }

    static void RegistrarUsuario()
    {
        Console.Write("Nombre: ");
        var nombre = Console.ReadLine();
        Console.Write("Tipo (1=Estudiante, 2=Profesor): ");
        var tipo = Console.ReadLine();

        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        if (tipo == "1")
        {
            Console.Write("Carrera: ");
            var carrera = Console.ReadLine();
            usuarios.Add(new Estudiante(id, nombre, carrera));
        }
        else
        {
            Console.Write("Departamento: ");
            var dep = Console.ReadLine();
            usuarios.Add(new Profesor(id, nombre, dep));
        }

        bitacora.RegistrarEvento($"Usuario {nombre} registrado.");
    }

    static void RealizarPrestamo()
    {
        if (usuarios.Count == 0 || libros.Count == 0)
        {
            Console.WriteLine("Faltan usuarios o libros.");
            return;
        }

        Console.WriteLine("Seleccione usuario:");
        for (int i = 0; i < usuarios.Count; i++)
            Console.WriteLine($"{i + 1}. {usuarios[i].Nombre}");

        int u = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Seleccione libro disponible:");
        var disponibles = libros.Where(l => l.Disponible).ToList();
        if (!disponibles.Any())
        {
            Console.WriteLine("No hay libros disponibles.");
            return;
        }

        for (int i = 0; i < disponibles.Count; i++)
            Console.WriteLine($"{i + 1}. {disponibles[i].Titulo}");

        int l = int.Parse(Console.ReadLine()) - 1;

        disponibles[l].Disponible = false;
        var prestamo = new Prestamo(usuarios[u], disponibles[l]);
        prestamos.Add(prestamo);

        bitacora.RegistrarEvento($"Prestamo realizado: {disponibles[l].Titulo} a {usuarios[u].Nombre}");
    }
}
