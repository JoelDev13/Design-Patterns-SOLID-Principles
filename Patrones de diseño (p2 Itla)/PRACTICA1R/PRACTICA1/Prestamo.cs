using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1
{
    public class Prestamo
    {
        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }
        public DateTime Fecha { get; set; }

        public Prestamo(Usuario usuario, Libro libro)
        {
            Usuario = usuario;
            Libro = libro;
            Fecha = DateTime.Now;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Prestamo: {Libro.Titulo} a {Usuario.Nombre} el {Fecha}");
        }

        // Sobrecarga
        public void Mostrar(bool conDetalles)
        {
            if (conDetalles)
                Mostrar();
            else
                Console.WriteLine($"Libro: {Libro.Titulo} prestado.");
        }
    }
}
