using System;

namespace ExeFixação_POO_clientes_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem vindo ao Hotel Samofalov!");
            System.Console.Write("Quantos quartos serão alugados? ");
            int alugados = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Estudante[] vet = new Estudante[10];
            for (int i = 0; i <= alugados ; i++){
                System.Console.WriteLine($"Aluguel #{i}:");
                System.Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Qaurto: ");
                int quarto = int.Parse(Console.ReadLine());
                System.Console.WriteLine();
                vet[quarto] = new Estudante(nome,email);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Quartos alugados:");
            for (int i = 0 ; i <= 10 ; i++ ){
                if (vet[i] != null){
                    System.Console.WriteLine(i+": "+vet[i]);
                }
            }
        }
    }
}
