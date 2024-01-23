using System;

class URI
{

    static void Main(string[] args)
    {


        int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n);
        foreach (int cedula in cedulas)
        {

            int count = n / cedula;
            n %= cedula;
            //Adicionado ",00" pois a plataforma não estava aceitando ":F2" ou "ToString("F2").
            System.Console.WriteLine($"{count} nota(s) de R$ {cedula},00");
        }

    }

}