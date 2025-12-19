using EjercioAdapter;
using System.Data;

do
{
    Console.Clear();
    Console.WriteLine("[1] leer archivo json");
    Console.WriteLine("[2] leer archivo csv");
    Console.WriteLine("eleija una opcion");
    int opcion = int.Parse(Console.ReadLine());
    EjercioAdapter.IDataReader reader;

    if (opcion == 1)
    {
        Console.WriteLine("contenido de archivo json");

        reader = new JsonDataReader()
        {
            Ruta = @"C:\Users\la\Desktop\Programacion\Mi roadmap backend\Patrones De Diseños c#\Adapter\EjercioAdapter\EjercioAdapter\jsonContenido.json"
        };
    }else if(opcion == 2){
        Console.WriteLine("contenido del archivo csv");

        reader = new CsvReaderAdapter(
            @"C:\Users\la\Desktop\Programacion\Mi roadmap backend\Patrones De Diseños c#\Adapter\EjercioAdapter\EjercioAdapter\csvContenido.csv"
        );
    }
    else
    {
        Console.WriteLine("opcion incorrecta");
        break;
    }
    try
    {
        Console.WriteLine(reader.ReadData());
    }catch (Exception e) 
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine("presione cualquiere tecla para continuar");
    Console.ReadKey();
}while (true);


