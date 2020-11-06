using System;

namespace Estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.Write("Digite quantos numeros voce quer digitar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++){
                Console.Write($"valor#{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            float media = soma / n;
            Console.WriteLine($"média = {media}");
        }
    }
}