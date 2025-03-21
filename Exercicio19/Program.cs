namespace Exercicio19
{
    internal class Program
    {
        //Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
        //encontram no conjunto dos números de 1 até 500.

        static void Main(string[] args)
        {
            Console.WriteLine("--- Soma de numeros Impares Multiplos de 3, de 1 a 500 ----\n");

            int soma = 0;
            for (int multiplo = 1; multiplo <= 500; multiplo++)
            {
                if (multiplo % 2 != 0 && multiplo % 3 == 0)
                {
                    soma += multiplo;
                }
            }
            Console.WriteLine(soma);

            Console.WriteLine("Deseja ver os numeros somados? S/N");
            string opcao = Console.ReadLine().ToUpper()!;

            if(opcao == "S")
            {
                for (int multiplo = 1; multiplo <= 500; multiplo++)
                {
                    if (multiplo % 2 != 0 && multiplo % 3 == 0)
                    {
                        Console.Write(multiplo + " + ");
                    }
                }
            }
            Console.WriteLine(" = " + soma);

            Console.ReadLine();
        }
    }
}
