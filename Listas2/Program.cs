using System;
using System.Collections.Generic;

namespace Listas2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listas2 = new List<string>();
            
            System.Console.WriteLine("Adicione quantas pessoas quiser na lista de convidados");
            char desejo = 's';
            while(desejo == 's'){
                System.Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();
                listas2.Add(nome);
                System.Console.Write("Deseja adicionar mais pessoas? s/n: ");
                desejo = char.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.Write("Quem voce deseja procurar? ");
            string pessoa = Console.ReadLine();
            string s = listas2.Find(x => x == pessoa);
            if (s != null){
                System.Console.WriteLine($"Pessoa encontrada, {s}");
            }
            else{
                System.Console.WriteLine("Pessoa não encontrada");
            }
        }
    }
}
