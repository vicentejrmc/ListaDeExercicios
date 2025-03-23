namespace Exercicio22
{
    internal class Program
    {
        // 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
        // Fibonacci: 0 1 1 2 3 5 8 13 21 34 55 89 144 ...
        // formula:
        // While c < numero;
        // c = a + b; if c < numero = cw;
        // a = b; b = c;
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sequência de Fibonacci ---\n");

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int fib = 0;

            Console.Write($"{a} {b}");

            while (fib < numero)
            {
                fib = a + b;
                if (fib < numero)
                {
                    Console.Write($" {fib}");
                }
                a = b;
                b = fib;
            }

            Console.ReadLine();
        }
    }
}
