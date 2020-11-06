using System;
using System.Collections.Generic;
namespace Iteração_com_lista_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Iteração na lista dobrando os numeros");
            //List<int> lista = new List<int> {1,2,3,4,5,6,7,8,9,10};
            //List<int> lista2 = new List<int>();
            //foreach (int obj in lista){
                 //int x = obj *2;
                //lista2.Add(x);
                //foreach(int obj1 in lista2){
                    //System.Console.WriteLine(obj);
            List<int> lista = new List<int> {1,2,3,4,5,6,7,8,9,10};
            System.Console.WriteLine(lista.Count);
            foreach(int obj in lista){
                int x  = obj *2;
                System.Console.Write($"{x},");
            }
        }
     }
}

