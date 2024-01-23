using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');

        double a = double.Parse(values[0]);
        double b = double.Parse(values[1]);
        double c = double.Parse(values[2]);

        double delta = Math.Pow(b, 2) - 4 * a * c;
 
        double raizDelta = Math.Sqrt(delta);

        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double r1 = (-b + raizDelta) / (2 * a);
            double r2 = (-b - raizDelta) / (2 * a);

            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}