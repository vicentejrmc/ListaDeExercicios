using System.Globalization;

namespace Exercicio05
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor.Deverá ser informado o salário base e o total de
        //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.

        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("---- Calculo de Salario: ----\n");

            Console.Write("Digite o nome do vendedor: ");
            string nomeVendedor = Console.ReadLine()!;

            Console.Write("Digite o Salario Base: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas do período: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o Pencentual a ser pago sobre Total de vendas: ");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());

            double comissao = totalVendas * (percentualComissao / 100);

            double salarioTotal = salarioBase + comissao;

            Console.Clear();
            Console.WriteLine("----- Resultado -----\n");

            Console.WriteLine($" - Nome do Vendedor: {nomeVendedor}.");
            Console.WriteLine($" - Salario base: {salarioBase.ToString("F2", CI)} R$");
            Console.WriteLine($" - Total de vendas: {totalVendas.ToString("F2", CI)} R$");
            Console.WriteLine($" - Valor total de Comissão:({percentualComissao}%) {comissao.ToString("F2", CI)} R$");
            Console.WriteLine($" - Salario Total a ser Pago: {salarioTotal.ToString("F2", CI )} R$");

            Console.ReadLine();
        }
    }
}
