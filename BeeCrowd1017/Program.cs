using System.Globalization;

namespace BeeCrowd1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hr, l;
            double km;

            hr = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());

            km = (double) hr * l / 12;

            Console.WriteLine("" + km.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
