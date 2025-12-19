using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificadorAdapterDemo
{
    public interface INotificador
    {
        void Enviar(string mensaje, string destinatario);
    }
}
