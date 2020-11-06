using System;
using System.Globalization;
namespace ExeFixação1_POO_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite a largura do retangulo: ");
            double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Digite a largura do retangulo: ");
            double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.WriteLine($"Area: {Retangulo.Area(altura,largura).ToString("F2",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Perimetro: {Retangulo.Perimetro(altura,largura).ToString("F2",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Diagonal: {Retangulo.Diagonal(altura,largura).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
