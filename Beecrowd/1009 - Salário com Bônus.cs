using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string nameSeller;

        nameSeller = Console.ReadLine();

        double salaryFix = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double sales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double comission = sales * 0.15;

        double total = salaryFix + comission;

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }

}