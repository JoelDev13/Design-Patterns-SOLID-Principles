using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica2
{
    internal class MensajeU
    {
        public DateTime FechaYHora { get; set; }
        public string Mensaje { get; set; }
        public string MensajeTipo { get; set; }

        public MensajeU(DateTime fechaYHora, string mensaje, string mensajeTipo)
        {
            FechaYHora = fechaYHora;
            Mensaje = mensaje;
            MensajeTipo = mensajeTipo;
        }

        public override string ToString()
        {
            return $"{FechaYHora.ToString("dd/MM/yyyy hh:mm tt"),-30}{Mensaje,-40}{MensajeTipo}";
        }
    }
}

 

