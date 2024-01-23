using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double areaCircunferencia,r, n = 3.14159;
        
        r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        areaCircunferencia = n * r * r;
        
        Console.WriteLine("A="+areaCircunferencia.ToString("F4", CultureInfo.InvariantCulture));
    }

}