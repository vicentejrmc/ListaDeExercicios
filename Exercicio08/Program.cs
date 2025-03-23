namespace Exercicio08
{
    internal class Program
    {
        //Crie um programa para verificar se um número é primo.
        //  número primo é um número natural(inteiro) maior que 1.
        //  ele não possui nenhum divisor além de 1 e ele mesmo.

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---- Identificador de Numero Primo ----\n");

                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                bool ePrimo = true;

                if (numero % 2 == 0)
                    ePrimo = false;

                string resultadoMsg = ePrimo ? "é primo" : "não é primo";

                Console.Clear();
                Console.WriteLine("---- Identificador de Numero Primo ----\n");

                Console.WriteLine($"O numero {numero} {resultadoMsg} ");

                Console.WriteLine("\n------------------------------------------");
                Console.Write("Deseja verificar outro numero? (S/N): ");
                string resposta = Console.ReadLine()!.ToUpper();
                
                if (resposta != "S")
                    break;
            }
        }
    }
}
