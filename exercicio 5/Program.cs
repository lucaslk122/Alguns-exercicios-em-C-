
using System;
using System.Globalization;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora de entrada do jogo: ");
            int hora_inicial = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.WriteLine("Digite a hora de saida do jogo: ");
            int hora_final = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            int duração;
            if (hora_final > hora_inicial){
                duração = hora_final - hora_inicial;
            }
            else{
                duração = 24 - hora_inicial + hora_final;
            }
            System.Console.WriteLine($"O jogo durou {duração} horas");
        }
    }
}
