namespace Exercicio15
{
    internal class Program
    {
        //O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
        //a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
        //peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
        //IMC em adultos Condição - Abaixo de 18,5 - Abaixo do peso - Entre 18,5 e 25 Peso normal - Entre 25 e 30 - Acima do peso - Acima de 30 obeso

        static void Main(string[] args)
        {
            Console.WriteLine("---- Calculo IMC ----\n");

            Console.Write("Digite o sue nome: ");
            string nome = Console.ReadLine()!;

            Console.Write("Digite o seu peso atual: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine($"O IMC é de: {imc.ToString("F2")}");

            if(imc < 18.5)
                Console.WriteLine($"{nome}, você está abaixo do peso ideal, coma um pouco mais!");
            else if (imc >= 18.5 && imc <= 25)
                Console.WriteLine($"{nome}, o seu peso está dentro do peso ideal");
            else if (imc > 25 && imc < 30)
                Console.WriteLine($"{nome}, você está acima do peso, segura aí filhão!");
            else
                Console.WriteLine($"{nome}, você está obeso, cuido meu 'fi'! cuide melhor de sua saúde!");


            Console.ReadLine();
        }
    }
}
