namespace BeeCrowd1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, hora, minuto, segundo, resto;

            num = int.Parse(Console.ReadLine());

            hora = num / 3600;
            resto = num % 3600;

            minuto = resto / 60;
            segundo = resto % 60;

            Console.WriteLine(hora + ":" + minuto + ":" + segundo + "");

        }
    }
}
