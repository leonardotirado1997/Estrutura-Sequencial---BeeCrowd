using System.Globalization;

namespace BeeCrowd1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, A, n = 3.14159;

            
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = n * (raio * raio);

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture)); 


        }
    }
}
