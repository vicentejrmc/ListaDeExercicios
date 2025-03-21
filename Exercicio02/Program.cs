namespace Exercicio02
{
    internal class Program
    {
        //crie um programa para calcular o volume de um cilindro
        // V = π . r² . h

        static void Main(string[] args)
        {
            Console.Write("Digite Raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Altura do cilindro:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"\nO volume do cilindro é: {volume.ToString("F3")}cm³ ");

            Console.ReadLine();
        }
    }
}
