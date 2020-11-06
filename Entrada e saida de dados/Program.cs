using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 25;
            string nome = "Lucas";
            float saldo = 1300F;
            double saida = 219381.21291298128;
            System.Console.WriteLine(saida.ToString("F2")); // Adicionamos ToString("Fquantidade de casas decimais")) para poder delimitar a quantidade de casas decimais de uma variavel.
            System.Console.WriteLine("{0} tem {1} anos e possui um total de {2} em conta",nome,idade,saldo);//Esse jeito é utilizado para fazer a concatenação, iniciei uma contagem de 0 até o numero de varaiveis que desjo imprimir, e depois, devo colocar na mesma ordem que foi soliciado.
            System.Console.WriteLine($"{nome} tem {idade} anos e possui um total de {saldo} em conta");//essa forma tem a mesma ideia que o python, lá usamos o f, aqui utilizamos o $
            System.Console.WriteLine(nome + " tem "+ idade + " e possui um total de " + saldo + " em conta");
        }
    }
}
