using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Exercicio11
{
    internal class Program
    {
        //Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
        //Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias
        //de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

        static void Main(string[] args)
        {
            Console.WriteLine("--- Quantos dias você já viviu? Tabjares ----\n");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int ano = 365;

            int diasVividos = idade * ano;

            Console.WriteLine($"{nome}, VOCÊ JÁ VIVEU {diasVividos} DIAS!");

            Console.ReadLine();
        }
    }
}
