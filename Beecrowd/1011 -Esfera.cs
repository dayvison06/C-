using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double r, pi = 3.14159;

        r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double volumeEsfera = (4.0 / 3.0) * pi * Math.Pow(r, 3);

        Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3", CultureInfo.InvariantCulture));

    }
}