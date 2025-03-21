namespace Exercicio18
{
    internal class Program
    {

        //18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        static void Main(string[] args)
        {
            Console.WriteLine("--- Gerador de numeros ímpares dentro do intervalo entre 100 e 200 ---\n");

            int numerosImpares = 0;

            Console.WriteLine("Os numeros ímpares entre 100 e 200 são:");
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    numerosImpares = i;
                    Console.Write($"{numerosImpares}, ");
                }
            }

            Console.ReadLine();
        }
    }
}
