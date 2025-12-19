using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; } = true;

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Libro: {Titulo} - {Autor} - {(Disponible ? "Disponible" : "Prestado")}");
        }
    }
}
