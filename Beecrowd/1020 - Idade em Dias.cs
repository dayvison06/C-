using System;

class URI
{

    static void Main(string[] args)
    {

        int daysToYears = int.Parse(Console.ReadLine());

        int year = daysToYears / 365;
        int month = (daysToYears % 365) / 30;
        int days = (daysToYears % 365) % 30;

        Console.WriteLine(year + " ano(s)");
        Console.WriteLine(month + " mes(es)");
        Console.WriteLine(days + " dia(s)");

    }

}