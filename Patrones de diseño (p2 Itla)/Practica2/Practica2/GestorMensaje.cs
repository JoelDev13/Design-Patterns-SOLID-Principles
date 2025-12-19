using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Practica2;

namespace Practica2
{
    internal class GestorMensaje
{
    private static GestorMensaje instance;
    private string rutaArchivo = "C:\\Users\\la\\Desktop\\Programacion\\Itla\\Programacion 2\\Practica2\\Practica2\\log.txt";

    private GestorMensaje()
    {
        if (!File.Exists(rutaArchivo))
        {
            using (StreamWriter archivo = File.CreateText(rutaArchivo))
            {
                archivo.WriteLine($"{"Fecha",-30}{"Mensaje",-40}{"Tipo"}");
            }
        }
    }

    public static GestorMensaje getInstance()
    {
        if (instance == null)
            instance = new GestorMensaje();
        return instance;
    }

    private void EscribirMensaje(MensajeU mensaje)
    {
        using (StreamWriter archivo = File.AppendText(rutaArchivo))
        {
            archivo.WriteLine(mensaje.ToString());
        }
    }

    public void InsertarMensaje(string tipo)
    {
        Console.Write($"Ingrese el mensaje de {tipo.ToLower()}: ");
        string comentario = Console.ReadLine();
        MensajeU mensaje = new MensajeU(DateTime.Now, comentario, tipo);
        EscribirMensaje(mensaje);
    }

    public void MostrarMensajes()
    {
        if (!File.Exists(rutaArchivo))
        {
            Console.WriteLine("No hay Mensajes disponibles.");
            return;
        }

        string[] lineas = File.ReadAllLines(rutaArchivo);
        Console.WriteLine("\n=== Registros de Mensajes ===");
        foreach (string linea in lineas)
        {
            Console.WriteLine(linea);
        }
    }
}
}