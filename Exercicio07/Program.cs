namespace Exercicio07
{
    internal class Program
    {
        // Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno.
        // ----------------------------------------------------------
        // formula = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2)
        // o peso será definido pelo Professor/Usuário.


        static void Main(string[] args)
        {
            Console.WriteLine("---- Calculo Média Ponderada ----\n");

            Console.Write("Digite o nome do Aluno: ");
            string nomeAluno = Console.ReadLine()!;

            Console.Write("Digite a nota da prova 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso da prova 1: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------------------------");
            
            Console.Write("Digite a nota da prova 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso da prova 2: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            string situacaoAluno = mediaPonderada < 6 ? "Reprovado" : "Aprovado";

            Console.WriteLine("---- Calculo Média Ponderada ----\n");
            Console.Clear();
            Console.WriteLine($"\nResultado do Aluno: {nomeAluno}");
            Console.WriteLine($"Nota 1: {nota1}, Peso: {peso1}");
            Console.WriteLine($"Nota 1: {nota2}, Peso: {peso2}");
            Console.WriteLine($"Média Ponderada = {mediaPonderada.ToString("F2")}");
            if(situacaoAluno == "Aprovado")
                Console.WriteLine($"Status do Aluno: ({situacaoAluno}). Parabéns, você conseguiu!");
            else
                Console.WriteLine($"Status do Aluno: ({situacaoAluno}). Estude mais um pouco e tente novamente!");

            Console.ReadLine();
        }
    }
}
