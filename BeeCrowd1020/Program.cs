namespace BeeCrowd1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeEmDias, ano, mes, dia, resto;

            idadeEmDias = int.Parse(Console.ReadLine());

            ano = (int)(idadeEmDias / 365);
            resto = idadeEmDias % 365;

            mes = (int)(resto / 30);

            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
