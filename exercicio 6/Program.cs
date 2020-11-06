using System;
using System.Globalization;
namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número qualquer: ");
            double numero = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            if (numero >=0.0 && numero <= 25.0){
                System.Console.WriteLine($"{numero} está no intervalo (0,25]");
            }
            else if (numero >=25.0 && numero <= 50.0){ 
                System.Console.WriteLine($"{numero} está no intervalo (25,50]");
            }
            else if (numero >= 50.0 && numero <= 70.0){
                System.Console.WriteLine($"{numero} está no intervalo (50,75]");
            }
            else if (numero >= 75.0 && numero <= 100.0){
                System.Console.WriteLine($"{numero} está no intervalo (75,100]");
            }
            else{
                System.Console.WriteLine("Fora de intervalo!");
            }
        }
    }
}
