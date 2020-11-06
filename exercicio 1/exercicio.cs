using System;
using System.Globalization;

namespace exercicios
{
    class produtos
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 620.50;
            double medida = 53.234567;
            System.Console.WriteLine("Produtos: ");
            System.Console.WriteLine($"{produto1},cujo o preço é {preco1}");
            System.Console.WriteLine($"{produto2},cujo o preço é {preco2}");
            System.Console.WriteLine($"Registro: {idade} anos de idade,código {codigo} e genero: {genero}");
            System.Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            System.Console.WriteLine($"Arredondamento (três casas decimais): {medida.ToString("F3",CultureInfo.InstalledUICulture)}");
        }
    }
}
