
using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
       
        int n = int.Parse(Console.ReadLine());

        int totalCobaias = 0;
        int totalCoelhos = 0;
        int totalRatos = 0;
        int totalSapos = 0;

       
        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int quantia = int.Parse(entrada[0]);
            char tipo = char.Parse(entrada[1]);

           
            totalCobaias += quantia;

            if (tipo == 'C')
                totalCoelhos += quantia;
            else if (tipo == 'R')
                totalRatos += quantia;
            else if (tipo == 'S')
                totalSapos += quantia;
        }

        double percentualCoelhos = (totalCoelhos * 100.0) / totalCobaias;
        double percentualRatos = (totalRatos * 100.0) / totalCobaias;
        double percentualSapos = (totalSapos * 100.0) / totalCobaias;

        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {totalCoelhos}");
        Console.WriteLine($"Total de ratos: {totalRatos}");
        Console.WriteLine($"Total de sapos: {totalSapos}");
        Console.WriteLine($"Percentual de coelhos: {percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {percentualRatos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {percentualSapos.ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}
