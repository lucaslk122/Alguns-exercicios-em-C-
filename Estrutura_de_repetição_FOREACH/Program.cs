using System;

namespace Estrutura_de_repetição_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] {"Sasasinha","Pepis","Tuta","Esjudi"};
            foreach (string obj in vet){
                System.Console.WriteLine(obj);
            }
        }
    }
}
