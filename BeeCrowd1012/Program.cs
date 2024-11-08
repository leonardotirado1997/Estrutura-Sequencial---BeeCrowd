using System.Globalization;

namespace BeeCrowd1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, pi = 3.14159, triangulo, circulo, trapezio, quadrado, retangulo;
            string[] valores;

            valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = pi * Math.Pow(c, 2.0);
            trapezio = (a + b) * c / 2.0;
            quadrado = Math.Pow(b, 2.0);
            retangulo = a * b;
           
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
