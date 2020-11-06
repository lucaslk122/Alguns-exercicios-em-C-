using System;
using System.Globalization;
namespace ExercicioFixacao_ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Quantos dolares voce vai comprar? ");
            double compra = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valor_a_ser_pago = ConversorDeMoeda.Conversor(cotacao,compra);
            System.Console.WriteLine($"Valor a ser pago em reais = {valor_a_ser_pago.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
