using System;
using System.Globalization;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço de um produto:");
            double preço_produto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preço_produto);

            System.Console.WriteLine("Entre com seu nome,idade e altura (na mesma linha)");
            string[] vets = Console.ReadLine().Split(" ");

            string nome1 = vets[0];

            int idade = int.Parse(vets[1]);

            double  altura = double.Parse(vets[0],CultureInfo.InvariantCulture);

            System.Console.WriteLine($"{nome1}, {idade} anos, {altura}");
        }
    }
}
