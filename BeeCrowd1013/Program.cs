namespace BeeCrowd1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, maiorAB, maior;
            string[] valores;

            valores = Console.ReadLine().Split(' ');

            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);
            valor3 = int.Parse(valores[2]);

            maiorAB = (valor1 + valor2 + Math.Abs(valor1 - valor2)) / 2;
            maior = (maiorAB + valor3 + Math.Abs(maiorAB - valor3)) / 2;


            Console.WriteLine(maior + " eh o maior");



        }
    }
}
