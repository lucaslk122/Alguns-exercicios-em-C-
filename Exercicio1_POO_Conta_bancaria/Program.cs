using System;
using System.Globalization;

namespace Exercicio1_POO_Conta_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            System.Console.WriteLine("Bem vindo ao banco Samofalov");
            System.Console.Write("Digite o número da sua conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            System.Console.WriteLine("Haverá deposito incial? (s/n)? ");
            string deposito_inicial = Console.ReadLine();
            if (deposito_inicial == "s" || deposito_inicial == "S"){
                System.Console.Write("Entre com o valor de depósito incial: ");
                double depositoIniciar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero,titular,depositoIniciar);
            }
            else{
                conta = new ContaBancaria(numero,titular);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta: ");
            System.Console.WriteLine(conta);
            System.Console.WriteLine();
            System.Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            System.Console.WriteLine("Dados da conta atualizado: ");
            System.Console.WriteLine(conta);
            System.Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            System.Console.WriteLine("Dados da conta atualizado: ");
            System.Console.WriteLine(conta);
        }
    }
}