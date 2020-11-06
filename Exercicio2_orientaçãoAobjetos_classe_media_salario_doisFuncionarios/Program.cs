using System;
using System.Globalization;

namespace Exercicio2_orientaçãoAobjetos_classe_media_salario_doisFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
        Funcionarios f1,f2;
        f1 = new Funcionarios();
        f2 = new Funcionarios();
        System.Console.Write("Digite seu nome: ");
        f1.nome = Console.ReadLine();
        System.Console.Write("Digite seu salario: ");
        f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        System.Console.Write("Digite seu nome: ");
        f2.nome = Console.ReadLine();
        System.Console.Write("Digite seu salario: ");
        f2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double media = ((f2.salario + f1.salario) / 2.0);
        System.Console.WriteLine($"A média de salarios é {media.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}
