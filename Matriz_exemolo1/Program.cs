using System;

namespace Matriz_exemolo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero N: ");
            int n = int.Parse(Console.ReadLine());
            int[ , ] mat = new int[n , n];
            for (int i = 0 ; i < n ; i++){
                string [] valores = Console.ReadLine().Split(" ");
                for (int  j = 0 ; j < n ; j++){
                    mat[i , j] = int.Parse(valores[j]);
                }
            }
            System.Console.WriteLine("Main diagonal: ");
            for (int i = 0 ; i < n ; i++){
                System.Console.Write(mat[i,i]+ " ");
            }
            System.Console.WriteLine();
            int cont = 0;
            for (int i = 0 ; i < n ;i++){
                for (int j = 0 ; j < n ; j++){
                    if (mat[i,j] < 0){
                        cont++;
                    }
                }
            }
            System.Console.Write("Negative numbers: "+cont);
        }
    }
}
