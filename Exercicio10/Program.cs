using System;

namespace Exercicio10
{
    internal class Program
    {
        //A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.Cada
        //pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
        //venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
        //Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
        //quantidades de pães e de broas, e depois calcular os dados solicitados.

        static void Main(string[] args)
        {

            Console.WriteLine("--- Padaria HotPão ---\n");
                        
            double valorPao = 0.12;            
            Console.Write("Digite a quantidade de pães vendidos: ");
            int qtePao = Convert.ToInt32(Console.ReadLine());

            double ValorBroa = 1.50;
            Console.Write("Digite a quantidade de broas vendidas: ");
            int qteBroa = Convert.ToInt32(Console.ReadLine()!);
            
            double totalPao = valorPao * qtePao;
            double totalBroa = qteBroa * ValorBroa;
            double totalVenda = totalPao + totalBroa;
            double poupanca = totalVenda * 0.10;

            Console.WriteLine("\n---- Resumo de Vendas ----\n");

            Console.WriteLine($"Total de vendas - Pães: R$ {totalPao}");
            Console.WriteLine($"Total de vendas - Broas: R$ {totalBroa}");
            Console.WriteLine($"Total de vendas pães e broas - R$ {totalVenda.ToString("F2")}");
            
            Console.WriteLine($"\nValor a ser guardado na poupança(10%) R$ {poupanca.ToString("F2")}");


            Console.ReadLine();
        }
    }
}
