using System;

class URI
{

    static void Main(string[] args)
    {

        int durationTime = int.Parse(Console.ReadLine());


        //Horas
        int convertHours = durationTime / 3600;

        //Minutos
        int minutos = (durationTime % 3600) / 60;

        //Segundos
        int convertSeconds = durationTime % 60;


        Console.WriteLine($"{convertHours}:{minutos}:{convertSeconds}");


    }

}