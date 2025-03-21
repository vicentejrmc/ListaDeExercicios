using System.Runtime.Intrinsics.X86;

namespace Exercicio01
{
    internal class Program
    {

        // Crie um programa para calcular o volume de uma caixa retangular
        // Fórmula: volume = largura * altura * comprimento
        static void Main(string[] args)
        {
            Console.WriteLine("---- Calculador de Volume de caixa ----\n");

            Console.Write("Digite a largura: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento: ");
            double comprimento = double.Parse(Console.ReadLine());

            double volume = largura * altura * comprimento;

            Console.WriteLine($"\nO volume da caixa é: {volume}");

            Console.ReadLine();
        }
    }
}
