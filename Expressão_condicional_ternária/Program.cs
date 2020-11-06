using System;
using System.Globalization;

namespace Expressão_condicional_ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço: ");
            double preço = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double desconto = (preço < 20.0)? preço*0.1 : preço*0.4; //(Condição) ? valor_se_verdade ; valor_se_falso.
            System.Console.Write($"Desconto: {desconto}");
        }
    }
}
