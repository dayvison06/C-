using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int tempoGastoViagem, velocidaMedia, consumoPorLitro;

        tempoGastoViagem = int.Parse(Console.ReadLine());
        velocidaMedia = int.Parse(Console.ReadLine());


        double litrosNecessario = tempoGastoViagem * velocidaMedia / 12.0;

        Console.WriteLine(litrosNecessario.ToString("F3", CultureInfo.InvariantCulture));

    }

}