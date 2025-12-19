using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificadorAdapterDemo
{
    public class WhatsAppAdapter : INotificador
    {
        WhatsAppService wService = new WhatsAppService();
        public void Enviar(string mensaje, string destinatario)
        {
                wService.EnviarWhatsApp(mensaje, destinatario);
        }
    }
}
