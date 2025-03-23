namespace Exercicio21
{
    internal class Program
    {
        //Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! (Fatorial) e o seu resultado
        //a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---- Fatorial ----\n");

                Console.Write("Digite um numero (Maximo = 33): ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"O resultado do fatorial de {numero} é:");
                Console.Write($"{numero}! = ");

                int fatorial = 1;
                for (int i = numero; i > 0; i--)
                {
                    fatorial *= i;
                    if (i >= 1)
                        Console.Write(i);
                    if (i > 1)
                        Console.Write(" X ");
                }

                Console.WriteLine($"= {fatorial}");

                Console.Write("\nDeseja verificar outro numero? S/N: ");
                string opcao = Console.ReadLine().ToUpper();
                if (opcao != "S")
                    break;
            }
        }
    }
}
