using NotificadorAdapterDemo;

public class Program
{
    static void Main(string[] args)
    {
        INotificador notificador = null;
        Console.Clear();
        Console.WriteLine("Elige una opcion [1]WhatsAppService [2]SmsNotificador [3]EmailNotificador");

        string input = Console.ReadLine();
        Console.Write("Ingresa el destinatario (numero o correo): ");
        string destinatario = Console.ReadLine();
        Console.Write("Ingresa el mensaje: ");
        string mensaje = Console.ReadLine();

        switch (input)
        {
            case "1":
                notificador = new WhatsAppAdapter();
                break;
            case "2":
                notificador = new SmsNotificador();
                break;
            case "3":
                notificador = new EmailNotificador();
                break;
            default:
                Console.WriteLine("Opcion no valida");
                return;
        }

        notificador.Enviar(mensaje, destinatario);
    }
}