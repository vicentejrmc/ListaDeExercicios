using System.Globalization;


namespace Exercicio06
{
    internal class Program
    {

        // Crie um programa para calcular a média harmônica das notas de um Aluno
        // ----------------------------------------------------------
        // Forma simplificada de calcular a média harmônica:
        // Formula: quantidadeDeNotas / somaDasNotas = (1/nota1 + 1/nota2 + 1/nota3 + ... + 1/notan)
        // 1. solicitar quantidade de notas - 2. criar array de notas - 3. somar array de notas(1/notas + ...)
        // 4 .dividir quantidade de notas pela soma das notas - 5. exibir resultado

        static void Main(string[] args)
        {
            Console.WriteLine("---- Calculo de média harmonica. ----\n");

            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine()!;

            Console.Write("Digite a quantidade de notas: ");
            int quantidadeNotas = Convert.ToInt32(Console.ReadLine());

            double[] notas = new double[quantidadeNotas];

            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            double soma = 0;
            for (int i = 0; i < quantidadeNotas; i++)
            {
                soma += 1 / notas[i];
            }

            double mediaHarmonica = quantidadeNotas / soma;

            Console.WriteLine("Resultados:");
            Console.WriteLine($"Nome do Aluno: {nomeAluno}");
            for(int i = 0; i < quantidadeNotas; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]}");
            }

            Console.WriteLine($"A Média harmonica do aluno é de: {mediaHarmonica.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
