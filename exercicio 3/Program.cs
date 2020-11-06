using System;
using System.Globalization;
namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o valor de um número: ");
            double numero = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            if (numero > 0){
                System.Console.WriteLine($"O numero {numero} é positivo",CultureInfo.InstalledUICulture);
            }
            else{
                System.Console.WriteLine($"O numero {numero} é negativo",CultureInfo.InstalledUICulture);
            }
        }
    }
}