using System;

class URI
{
    static void Main(string[] args)
    {

        string[] enter = Console.ReadLine().Split(' ');

        int a, b, c, d;

        a = int.Parse(enter[0]);
        b = int.Parse(enter[1]);
        c = int.Parse(enter[2]);
        d = int.Parse(enter[3]);

        int somaCD = c + d;
        int somaAB = a + b;

        if (b > c && d > a)
        {
            if (somaCD > somaAB)
            {
                if (c > 0 && d > 0)
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Valores aceitos");
                    }
                    else
                    {
                        Console.WriteLine("Valores nao aceitos");
                    }
                }
                else
                {
                    Console.WriteLine("Valores nao aceitos");
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}