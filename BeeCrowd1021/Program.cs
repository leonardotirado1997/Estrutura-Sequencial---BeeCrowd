using System.Globalization;

namespace BeeCrowd1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quociente, resto, nota, moeda;
            double valor;
            

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Multiplicamos o valor por 100 par a forçar a conversão para um valor INT: 576.73 agora é 57673
              Tivemos que somar com 0.5 antes de converter para assegurar que o numero seja DEVIDAMENTE arredondado pois o tipo DOUBLE
              as vezes tem problema de arredondamento (ex: 576.81 e ficou 57680) 
            */

            resto = (int)(valor  * 100 + 0.5);

            Console.WriteLine("NOTAS: ");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 100.00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 50.00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 20.00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 10.00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 5.00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ 2.00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS: ");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");

        }
    }
}
