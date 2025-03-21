using System.Runtime.Intrinsics.Arm;

namespace Exercicio14
{
    internal class Program
    {
        // Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            Console.WriteLine("--- Impressão decrescente de valores Decrescente ---\n");

            Console.WriteLine("Digite tres valores inteiros para que eu os organizarei para você.");

            Console.Write("Digite o 1° valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2° valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 3° valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valores impressos ordem Decrescente:");
            if (valor1 < valor2 && valor1 < valor3)
            {
                if (valor2 < valor3)
                    Console.WriteLine($"{valor3} , {valor2} , {valor1}");
                else
                    Console.WriteLine($"{valor2} , {valor3} , {valor1}");
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                if (valor1 < valor3)
                    Console.WriteLine($"{valor3} , {valor1} , {valor2}");
                else
                    Console.WriteLine($"{valor1} , {valor3} , {valor2}");
            }
            else
            {
                if (valor1 < valor2)
                    Console.WriteLine($"{valor3} , {valor1} , {valor2}");
                else
                    Console.WriteLine($"{valor1} , {valor2} , {valor3}");
            }

            Console.ReadLine();
        }
    }
}
