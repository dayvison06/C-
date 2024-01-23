using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int id, hoursWorked;
        double salaryPerHour;

        id = int.Parse(Console.ReadLine());
        hoursWorked = int.Parse(Console.ReadLine());
        salaryPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salary = salaryPerHour * hoursWorked;

        Console.WriteLine("NUMBER = " + id);
        Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

    }

}