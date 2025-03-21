namespace Exercicio03
{
    internal class Program
    {
       //Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.O
       //programa deve solicitar ao usuário:
       //- A quilometragem inicial do veículo no início da viagem.
       //- A quilometragem final ao término da viagem.
       //- A quantidade de combustível consumida durante a viagem(em litros).

        static void Main(string[] args)
        {
            Console.Write("Digite a Kilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Kilometragem final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de Combustivel usada: ");
            double comsumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = kmFinal - kmInicial;
            double consumoPorKm = distanciaPercorrida / comsumoCombustivel;

            Console.WriteLine($"\nVocê percorreu uma distancia de: {distanciaPercorrida}km");
            Console.WriteLine($"O consumo de combustivel foi de ~ {consumoPorKm}L  por km rodado.");
            
            Console.ReadLine();
        }
    }
}
