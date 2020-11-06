using System;
using System.Collections.Generic;

namespace Listas1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Numero: ");
            int n = int.Parse(Console.ReadLine());
            List<int> lista2 = new List<int>(); //instanciação de uma lista, foi criado uma lista vazis
            for (int i = 0; i < n; i++){
                int x = i + 1 ;
                lista2.Add(x);
                foreach(int obj in lista2){
                    System.Console.WriteLine(obj);
                }
            }
        }
    }
}
