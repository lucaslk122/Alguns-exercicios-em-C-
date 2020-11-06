using System;

namespace operadores_comparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Que horas são?");
            float horas = float.Parse(Console.ReadLine());
            if (horas <=12.00) {
                System.Console.WriteLine("Bom dia!");
            }
            else if (horas <=18.00){
                System.Console.WriteLine("Boa tarde");
            }
            else{
                System.Console.WriteLine("Boa noite");
            }
        }
    }
}
