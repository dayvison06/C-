using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double[] notes = { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0 };
        double[] coins = { 1.0, 0.50, 0.25, 0.10, 0.05, 0.01 };

        double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("NOTAS:");

        foreach (double note in notes)
        {
            if (n >= 0 && n <= 1000000.00)
            {
                int division = (int)(n / note);
                n = n % note;
                Console.WriteLine($"{division} nota(s) de R$ {note.ToString("F2", CultureInfo.InvariantCulture)}");
                n = Math.Round(n, 2);

            }

        }

        Console.WriteLine("MOEDAS:");

        foreach (double coin in coins)
        {
            if (n >= 0 && n <= 1000000.00)
            {
                int division = (int)(n / coin);
                n = n % coin;
                Console.WriteLine($"{division} moeda(s) de R$ {coin.ToString("F2", CultureInfo.InvariantCulture)}");
                n = Math.Round(n, 2);
            }
        }

    }
}