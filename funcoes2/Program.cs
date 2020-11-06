
using System;
using System.Globalization;
namespace funcoes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero:");
            double x = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            while(x > 0.0){
            double raiz = Math.Sqrt(x);
            System.Console.WriteLine(raiz.ToString("F3",CultureInfo.InvariantCulture));
            System.Console.Write("Digite outro número:");
            x = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            }
            System.Console.WriteLine("Numero negativo!");
        }
    }
}
