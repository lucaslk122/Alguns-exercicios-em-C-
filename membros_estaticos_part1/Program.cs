using System;
using System.Globalization;
namespace membros_estaticos_part1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            System.Console.WriteLine($"Circunferencia: {circ.ToString("F3",CultureInfo.InvariantCulture)}");
            double vol = Volume(raio);
            System.Console.WriteLine($"Volume: {vol.ToString("F3",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"PI: {Math.PI.ToString("F10",CultureInfo.InvariantCulture)}");
        }
        static double Circunferencia(double r){
            return 2.0 * Math.PI * r;
        }
        static double Volume(double r){
            return (4.0/3.0)*Math.PI*Math.Pow(r,3);
        }
    }
}
