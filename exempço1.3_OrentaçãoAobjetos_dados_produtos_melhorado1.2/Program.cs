﻿using System;
using System.Globalization;
namespace exempço1_OrentaçãoAobjetos_dados_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com os dados do produto:");
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Qunatidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome,preco,quantidade);
            System.Console.WriteLine($"Dados do produto: " + p);
            System.Console.WriteLine();
            System.Console.Write("Digite o numero de produtos a ser adicionados ao estoque: ");
            int qts = int.Parse(System.Console.ReadLine());
            p.AdicionarProdutos(qts);
            System.Console.Write("Dados atualizados: "+ p);
            System.Console.WriteLine();
            System.Console.Write("Digite o numero de produtos a ser removidos do estoque: ");
            qts = int.Parse(System.Console.ReadLine());
            p.RemoverProdutos(qts);
            System.Console.Write("Dados atualizados: "+ p);
        }
    }
}
