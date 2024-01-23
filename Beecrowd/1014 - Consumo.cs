using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double consumoMedio = X / Y;

        Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

    }

}