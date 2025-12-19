using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1
{
    public abstract class Usuario : IRegistrable
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public Usuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public abstract void MostrarInfo();

        public virtual void Registrar()
        {
            Console.WriteLine($"Usuario {Nombre} registrado.");
        }
    }
}
