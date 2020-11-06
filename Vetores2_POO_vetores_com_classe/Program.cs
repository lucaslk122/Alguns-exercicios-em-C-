using System;
using System.Globalization;

namespace Vetores2_POO_vetores_com_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o numero de equipamentos: ");
            int n = int.Parse(Console.ReadLine());
            Produtos[] vet = new Produtos[n];
            for(int i = 0 ; i < n ; i++){
                System.Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                System.Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
                vet[i] = new Produtos{Nome = name , Preco = price};
            }
            double sum = 0.0;
            for(int i = 0; i < n ; i++){
                sum += vet[i].Preco;
            }
            double media = sum/n;
            System.Console.WriteLine("Média de preços: " + media.ToString("F2",CultureInfo.InstalledUICulture));
        }
    }
}