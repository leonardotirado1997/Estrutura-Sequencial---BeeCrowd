namespace BeeCrowd1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaIn, horaIn, minIn, segIn, diaFn, horaFn, minFn, segFn;
            int evF1, evF2, total;
            int dias, horas, minutos, segundos;

            string[] dia1, dia2, vet1, vet2;

            dia1 = Console.ReadLine().Split(' ');
            diaIn = int.Parse(dia1[1]);

            vet1 = Console.ReadLine().Split(':');
            horaIn = int.Parse(vet1[0]);
            minIn = int.Parse(vet1[1]);
            segIn = int.Parse(vet1[2]);

            dia2 = Console.ReadLine().Split(' ');
            diaFn = int.Parse(dia2[1]);

            vet2 = Console.ReadLine().Split(':');
            horaFn = int.Parse(vet2[0]);
            minFn = int.Parse(vet2[1]);
            segFn = int.Parse(vet2[2]);

            evF1 = diaIn * 24 * 60 * 60 + horaIn * 60 * 60 + minIn * 60 + segIn;
            evF2 = diaFn * 24 * 60 * 60 + horaFn * 60 * 60 + minFn * 60 + segFn;

            total = evF2 - evF1;

            dias = total / (24 * 60 * 60);
            total = total % (24 * 60 * 60);
            horas = total / (60 * 60);
            total = total % (60 * 60);
            minutos = total / 60;
            total = total % 60;
            segundos = total;

            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");
        }
    }
}
