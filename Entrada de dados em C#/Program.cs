using System;
using System.Globalization;

namespace Entrada_de_dados_em_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados pelo usuário
            //O comando para o console ler a entrada de dados, é Console.ReadLine()
            //Podemos usar o .split igual é no python
            //System.Console.WriteLine("Digite sua mensagem: ");
            //string frase = Console.ReadLine();
            //System.Console.WriteLine($"voce digitou {frase}");
            //System.Console.WriteLine("Digite tres cores: ");
            //string[] vets = System.Console.ReadLine().Split(" ");
            //string p1 = vets[0];
            //string p2 = vets[1];
            //string p3 = vets[2];
            //System.Console.WriteLine(p1);
            //System.Console.WriteLine(p2);
            //System.Console.WriteLine(p3);
           System.Console.WriteLine("Dgite seu nome,idade,sexo e altura");
           string[] vets = System.Console.ReadLine().Split(" ");
           string nome = vets[0];
           int idade = int.Parse(vets[1]);
           char genero = char.Parse(vets[2]);
           double altura = double.Parse(vets[3],CultureInfo.InvariantCulture);
           System.Console.WriteLine($"Bom dia {nome}, voce tem {idade} anos, é do sexo {genero} e possui {altura} metros");
        }
    }
}