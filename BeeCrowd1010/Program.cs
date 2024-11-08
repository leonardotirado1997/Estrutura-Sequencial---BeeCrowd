using System.Globalization;

namespace BeeCrowd1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CodPeca1, CodPeca2, NumPeca1, NumPeca2;
            double ValorPeca1, ValorPeca2, ValorFinal;
            string[] valores;

            valores = Console.ReadLine().Split(' ');
            CodPeca1 = int.Parse(valores[0]);
            NumPeca1 = int.Parse(valores[1]);
            ValorPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            CodPeca2 = int.Parse(valores[0]);
            NumPeca2 = int.Parse(valores[1]);
            ValorPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);


            ValorFinal = (double)(ValorPeca1 * NumPeca1 + ValorPeca2 * NumPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorFinal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
