using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificadorAdapterDemo
{
    public class SmsNotificador : INotificador
    {
        public void Enviar(string mensaje, string destinatario)
        {
            Console.WriteLine("soy un SmsNotificador");
        }
    }
}
