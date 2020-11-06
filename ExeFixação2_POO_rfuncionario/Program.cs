using System;
using System.Globalization;

namespace ExeFixação2_POO_rfuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            System.Console.Write("Digite seu nome: ");
            func.Nome = Console.ReadLine();

            System.Console.Write("Digite seu salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);

            System.Console.Write("Digite o imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            System.Console.WriteLine($"Funcionario " + func);

            System.Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            func.AumentarSalario(porcentagem);

            System.Console.WriteLine();

            System.Console.Write("Dados atualizados: " + func);
        }
    }
}
