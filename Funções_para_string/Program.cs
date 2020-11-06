using System;

namespace Funções_para_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcd fgh HSUHUHS SUAHUHSUAHS lmn opq   ";
            string s = original.ToUpper(); //todas as strings para maiusculo
            string s2 = original.ToLower(); // todo mundo para minusculo
            string s3 = original.Trim(); //apaga todos os espaços em branco
            int n1 = original.IndexOf("bc"); // vai retornar qual é o indice da minha procura
            string s4 = original.Replace("a","NNN999"); //muda a primeira entrada pela segunda
            bool b1 = string.IsNullOrEmpty(original); //vai testar se minha string é vazia
            bool b2 = string.IsNullOrWhiteSpace(original) ;// vai testar se a variavel é nuka ou esoaço vazio
            System.Console.WriteLine(original);
            System.Console.WriteLine("-------------");
            System.Console.WriteLine(s);
            System.Console.WriteLine("-------------");
            System.Console.WriteLine(s2);
            System.Console.WriteLine("-------------");
            System.Console.WriteLine(s3);
            System.Console.WriteLine("-------------");
            System.Console.WriteLine(n1);
            System.Console.WriteLine("-------------");
            System.Console.WriteLine(s4);
            System.Console.WriteLine("-------------");
            System.Console.WriteLine(b1);
            System.Console.WriteLine("-------------");
             System.Console.WriteLine(b2);
            System.Console.WriteLine("-------------");
        }
    }
}
