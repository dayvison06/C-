using System;
using System.Globalization;

namespace PraticandoBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            double tempoGastoViagem, velocidaMedia, consumoPorLitro, precoGasolina, distanciaPercorrida;
            string option;

            Console.WriteLine("CALCULADORA PARA MEDIR CONSUMO DE GASOLINA\n");
            Console.Write("Informe o tempo de viagem em horas: ");
            tempoGastoViagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Velocidade média do veículo: ");
            velocidaMedia= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quanto o carro faz por litro: ");
            consumoPorLitro= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double litrosNecessario = tempoGastoViagem * velocidaMedia / consumoPorLitro;

            Console.WriteLine("\nO consumo é de " + litrosNecessario.ToString("F2", CultureInfo.InvariantCulture) + " litros\n");

            Console.WriteLine("Deseja calcular o valor a ser gasto?\n ");
            Console.WriteLine("Digite 'S' para sim e 'N' para não");
            option = Console.ReadLine().ToUpper();
            

            switch (option)
            {
                case "S":
                    Console.Write("\nPreço médio da gasolina por litro: ");
                    precoGasolina = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double gastoGasolina = litrosNecessario * precoGasolina;
                    Console.WriteLine("\nSerá gasto o total de R$: " + gastoGasolina.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case "N":
                    Console.WriteLine("Obrigado por utilizar!");
                    break;
            }
        }
    }
}