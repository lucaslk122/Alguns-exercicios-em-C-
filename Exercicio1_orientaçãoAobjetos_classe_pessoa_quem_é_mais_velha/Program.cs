using System;

namespace Exercicio1_orientaçãoAobjetos_classe_pessoa_quem_é_mais_velha
{
    class Program
    {
        static void Main(string[] args)
        {
        Pessoas p1,p2;
        p1 = new Pessoas();
        p2 = new Pessoas();
        System.Console.WriteLine("Dados da primeira pessoa: ");
        System.Console.Write("Nome: ");;
        p1.nome = Console.ReadLine();
        System.Console.Write("Idade: ");
        p1.idade = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Dados da segunda pessoa: ");
        System.Console.Write("Nome: ");
        p2.nome = Console.ReadLine();
        System.Console.Write("Idade: ");
        p2.idade = int.Parse(Console.ReadLine());
        if (p1.idade > p2.idade){
            System.Console.WriteLine($"{p1.nome} é mais velha(o)");
        }
        else{
           System.Console.WriteLine($"{p2.nome} é mais velha(o)");
        }
        }
    }
}
