using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite c");
            int c = int.Parse(Console.ReadLine());
            double resultado = maior_valor(a,b,c); //cria uma função com o nome desejado, nesse caso "maior_valor" e assim, pasamos os parametros que desejamos a serem retornados,esse resultado vamos armazenar numa variavel chamada "resultado" e por fim,mandado printar esse resultado.
            System.Console.WriteLine($"O maior número é {resultado}");
        }
    static int maior_valor(int a,int b,int c){
        int m;
        if (a > b && a > c){
            m = a;
        }
        else if (b > c ) {
            m = b;
        }
        else{
            m = c;
        }
        return m;
        }
    }
}
