using System;
using System.Globalization;
namespace membros_estaticos_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            System.Console.WriteLine("Circunferencia: "+circ.ToString("F2",CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: "+volume.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
