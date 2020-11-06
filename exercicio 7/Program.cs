using System;
using System.Globalization;
namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a coordenadas de um ponto no eixo x e no eixo y: ");
            string[] vet = System.Console.ReadLine().Split(" ");
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);
            if (x == 0 && y == 0){
                System.Console.WriteLine("O ponto está na origem");
            }
            else if (x>0 && y>0){
                System.Console.WriteLine("O ponto está no Primeiro quadrrante");
            }
            else if (x<0 && y<0){
                System.Console.WriteLine("O ponto está no terceiro quadrante");
            }
            else if (x<0 && y>0){
                System.Console.WriteLine("O pont está no segundo quadrante");
            }
            else{
                System.Console.WriteLine("O ponto está no quarto quadrante");
            }

        }
    }
}
