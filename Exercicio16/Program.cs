namespace Exercicio16
{
    internal class Program
    {
        // 16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("---- O numereo é Par ou Impar? ----\n");

                Console.Write("Digite um numero: ");
                double numero = Convert.ToDouble(Console.ReadLine());

                if (numero % 2 == 0)
                    Console.WriteLine("O numero digitado é PAR.");
                else
                    Console.WriteLine("O numero digitado é IMPAR.");

                Console.Write("\nVerificar outro numero? S/N: " );
                string opcao = Console.ReadLine().ToUpper();
                if(opcao != "S")
                    break;
            }
        }
    }
}
