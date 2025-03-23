using System;

namespace Exercicio04
{
    internal class Program
    {
        // Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        // A fórmula de conversão é: F = C * 1.8 + 32
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Conversor Celsius para Fahrenheit.");
            Console.WriteLine("----------------------------------\n");
          
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"\nO Equivalenete em Fahrenheit é de: {fahrenheit.ToString("F2")}°F");

            Console.ReadLine();
        }
    }
}
