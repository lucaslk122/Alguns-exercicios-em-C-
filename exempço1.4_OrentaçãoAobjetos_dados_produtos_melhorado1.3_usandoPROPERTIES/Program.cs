using System;
using System.Globalization;
namespace exempço1_OrentaçãoAobjetos_dados_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV",5000.00,10);
                p.Nome = "Playstation 5";
            System.Console.WriteLine(p.Nome);
            System.Console.WriteLine(p.Preco);
        }
    }
}