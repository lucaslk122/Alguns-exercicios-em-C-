using System;
using System.Globalization;
namespace membros_estaticos_part2
{
    public class Calculadora
    {
        public static double Circunferencia( double raio){
            return 2.0 * Math.PI * raio;
        }
        public static double Volume(double raio){
            return (4.0/3.0)*Math.PI*Math.Pow(raio,3);
        }
    }
}