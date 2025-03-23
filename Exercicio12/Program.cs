using System.Runtime.ConstrainedExecution;

namespace Exercicio12
{
    internal class Program
    {
        //12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
        //impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Salário ----\n");

            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor do Salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double salarioAumento = salario * 0.15;
            salarioAumento += salario;

            double imposto = salarioAumento * 0.08;
            double salarioFinal = salarioAumento - imposto;

            Console.WriteLine("\nResultado de Calculos");
            Console.WriteLine($"Salário iniciao: {salario}");
            Console.WriteLine($"Salário com aumento de 15%: {salarioAumento}");
            Console.WriteLine($"Salário final com a dedução de 8%: {salarioFinal}");

            Console.ReadLine();
        }
    }
}
