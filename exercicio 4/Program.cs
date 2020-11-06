using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro e positivo: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0){
                System.Console.WriteLine($"{x} é PAR");
            }
            else{
                System.Console.WriteLine($"{x} é IMPAR");
            }
        }
    }
}
