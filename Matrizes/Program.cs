using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[ , ] mat = new double [2,3]; //Como instanciar uma matriz, criamos uma matriz vazia e depois dizemos qual será o tamanho, para esse caso, sera uma matriz 2 por 3
            System.Console.Write("Tamanho da matriz: " + mat.Length); // tamanho da matriz
            System.Console.WriteLine();
            System.Console.WriteLine("Dimensão da matriz: "+mat.Rank); //quantidade de linhas
            System.Console.WriteLine();
            System.Console.Write(mat.GetLength(0)); 
            System.Console.WriteLine();
            System.Console.Write(mat.GetLength(1));
        }
    }
}
