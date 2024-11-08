using System.Globalization;

namespace BeeCrowd1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int funcionario, horas;
            double salario, resultado;

            funcionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = horas * salario;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
