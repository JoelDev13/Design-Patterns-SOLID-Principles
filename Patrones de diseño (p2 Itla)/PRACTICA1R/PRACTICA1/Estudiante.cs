using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRACTICA1
{
    public class Estudiante : Usuario
    {
        public string Carrera { get; set; }

        public Estudiante(int id, string nombre, string carrera) : base(id, nombre)
        {
            Carrera = carrera;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {Nombre}, Carrera: {Carrera}");
        }

        public override void Registrar()
        {
            Console.WriteLine($"Estudiante {Nombre} registrado con ID {Id}.");
        }
    }

    public class Profesor : Usuario
    {
        public string Departamento { get; set; }

        public Profesor(int id, string nombre, string departamento) : base(id, nombre)
        {
            Departamento = departamento;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Profesor: {Nombre}, Departamento: {Departamento}");
        }
    }
}
