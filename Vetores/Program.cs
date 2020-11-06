using System;
using System.Globalization;
namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n]; //Cria um vetor do tipo double, o comando posterior serve para criar um vetor com a quantidade de elementos que quisermos, no caso, vale n.
            System.Console.WriteLine();
            System.Console.WriteLine("Digite a altura das pessoas");
            for (int i = 0; i < n ;i++){
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for(int i = 0 ; i< n ; i++){
                sum +=  vet[i];
            }
            double avg = sum/n;
            System.Console.WriteLine($"Altura média: {avg.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
