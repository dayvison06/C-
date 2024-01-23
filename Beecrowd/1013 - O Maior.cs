using System;

class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');

        int A = int.Parse(values[0]);
        int B = int.Parse(values[1]);
        int C = int.Parse(values[2]);

        int maiorAB = (A + B + Math.Abs(A - B)) / 2;
        int maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

        Console.WriteLine(maior + " eh o maior");

    }

}