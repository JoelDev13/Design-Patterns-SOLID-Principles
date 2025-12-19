using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1
{
    public class Bitacora
    {

        private List<string> eventos = new();

        public void RegistrarEvento(string mensaje)
        {
            eventos.Add($"{DateTime.Now}: {mensaje}");
        }

        public void MostrarEventos()
        {
            foreach (var evento in eventos)
                Console.WriteLine(evento);
        }
    }
}
