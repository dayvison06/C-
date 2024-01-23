using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');

        double Vend1 = int.Parse(p1[1]) * double.Parse(p1[2], CultureInfo.InvariantCulture);
        double Vend2 = int.Parse(p2[1]) * double.Parse(p2[2], CultureInfo.InvariantCulture);

        double total = Vend1 + Vend2;

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }

}