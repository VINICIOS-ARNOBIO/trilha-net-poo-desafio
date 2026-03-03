using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("11999999999", "Tijolão", "123456789", 64);
        Iphone iphone = new Iphone("11888888888", "iPhone 15", "987654321", 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}