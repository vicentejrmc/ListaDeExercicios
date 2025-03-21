namespace Exercicio17
{
    internal class Program
    {
        //Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
        //contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
        //variável C e mostrar seu conteúdo na tela.

        static void Main(string[] args)
        {
            Console.WriteLine("---- Soma se for igual - Multiplica os diferentes ----\n");

            Console.Write("Digite o 1° valor: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o 2° valor: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            double valorC = 0;
            if (valorA == valorB)
            {
                valorC = valorA + valorB;
                Console.WriteLine("Pos serem iguais, os valores foram Somados");
                Console.WriteLine($"O resultado é: {valorC}");
            }
            else
            {
                valorC = valorA * valorB;
                Console.WriteLine("Como são diferentes, os valores foram Multiplicados");
                Console.WriteLine($"O resultado é {valorC}");
            }




            Console.ReadLine();
        }
    }
}
