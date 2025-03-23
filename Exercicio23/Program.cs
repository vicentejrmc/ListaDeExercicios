namespace Exercicio23
{
    internal class Program
    {
         //Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
         //múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". Para números que são múltiplos de
         //ambos, use "FizzBuzz".


        static void Main(string[] args)
        {
            Console.WriteLine("---- Fizz Buzz e FizZBuzz ----\n");
            Console.WriteLine("Multiplos de 3 e 5 = FizzBuzz, multilos de 5 = Buzz e multiplos de 3 == Fizz\n");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz, ");
                else if (i % 5 == 0)
                    Console.Write("Buzz, ");
                else if (i % 3 == 0)
                    Console.Write("Fizz, ");
                else
                    Console.Write(i + ", ");
            }

            Console.ReadLine();
        }
    }
}
