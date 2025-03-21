namespace Exercicio20
{
    internal class Program
    {
        //Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.Mostre a
        //tabuada na forma:
        //0 x N = 0,
        //1 x N = 1N,
        //2 x N = 2N,
        //...

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Tabuada 1 a 10 ---\n");

                Console.Write("Digite um numero de 1 a 10: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"--- A tabuada de {numero} é: ---");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} x {numero} = {i * numero}");
                }

                Console.Write("\nDeseja Continuar? (S/N): ");
                string continuar = Console.ReadLine()!.ToUpper();

                if (continuar == "N")
                    break;
            }
        }
    }
}
