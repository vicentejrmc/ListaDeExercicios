using System;

namespace Exercicio09
{
    internal class Program
    {
        //A imobiliária Imóbilis vende apenas terrenos retangulares.Faça um algoritmo para ler as dimensões de um
        //terreno e depois exibir a área do terreno.

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();    
                Console.WriteLine("----------------------------------");
                Console.WriteLine("---- Imobiliária 'Imóbilis' ----");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("------ Verificdor de Área --------\n");

                Console.WriteLine("Insira os dados do terreno.");
                
                Console.Write("Largura: ");
                double largura = Convert.ToDouble(Console.ReadLine()!);

                Console.Write("Comprimento: ");
                double comprimento = Convert.ToDouble(Console.ReadLine()!);

                double terrenoArea = largura * comprimento;

                Console.Write("Valor do Terreno: R$ ");
                double valoDoTerreno = Convert.ToDouble(Console.ReadLine()!);

                double valorM2 = valoDoTerreno / terrenoArea;

                Console.WriteLine($"\nA área do terreno digitado é de {terrenoArea}M²");
                Console.WriteLine($"O valor do M² é de: R$ {valorM2.ToString("F2")}\n");

                Console.Write("Deseja Verificar outro Terreno? S/N: ");
                string opcao = Console.ReadLine()!.ToUpper();
                if (opcao != "S")
                    break;
            }         
        }
    }
}
