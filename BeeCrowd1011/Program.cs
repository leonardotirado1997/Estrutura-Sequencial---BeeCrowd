using System.Globalization;

namespace BeeCrowd1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, pi = 3.14159;
            int raio;

            raio = int.Parse(Console.ReadLine());

            volume = (4/3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
