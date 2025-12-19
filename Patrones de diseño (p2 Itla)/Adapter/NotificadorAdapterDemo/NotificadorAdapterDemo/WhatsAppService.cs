using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificadorAdapterDemo
{
    public class WhatsAppService
    {
        public void EnviarWhatsApp(string numero, string texto)
        {
            Console.WriteLine($"[WhatsApp] Enviando a {numero}: {texto}");
        }

       
    }

}
