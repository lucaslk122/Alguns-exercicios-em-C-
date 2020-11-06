using System;
namespace ExeFixação1_POO_retangulo
{
    public class Retangulo
    {
        public static double Area(double largura, double altura){
            return largura*altura;
        }
        public static double Perimetro(double largura, double altura){
            return (2.0*largura) + (2.0*altura);
        }
        public static double Diagonal(double largura, double altura){
            return Math.Sqrt(Math.Pow(largura,2) + Math.Pow(altura,2));
        }
    }
}