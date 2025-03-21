namespace Exercicio13
{
    internal class Program
    {
        // Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Valores A + B > C ? ----\n");

            Console.Write("Digite o valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int valorC = Convert.ToInt32(Console.ReadLine());

            int soma = valorA + valorB;

            if (soma > valorC)
            {
                Console.WriteLine($"O Valor da soma de A + B  é MAIOR.");
                Console.WriteLine($"Soma A + B = {soma}. Valor de C = {valorC}");
            }
            else
            {
                Console.WriteLine($"O Valor da soma de A + B  é MENOR.");
                Console.WriteLine($"Soma A + B = {soma}. Valor de C = {valorC}");
            }


                Console.ReadLine();
        }
    }
}
