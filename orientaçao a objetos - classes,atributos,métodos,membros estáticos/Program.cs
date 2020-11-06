using System;
using System.Globalization;

namespace orientaçao_a_objetos___classes_atributos_métodos_membros_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,a1,b1,c1;
            Console.WriteLine("Entre com as 3 medidas do triangulo x");
            a = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);   
            b = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            c = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            double px = (a + b + c) / 2.0;
            double areax = Math.Sqrt(px*(px-a)*(px-b)*(px-c));
            System.Console.WriteLine("Area de x = {0}",areax.ToString("f4",CultureInfo.InvariantCulture));
            Console.WriteLine("Entre com as 3 medidas do triangulo y");
            a1 = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);   
            b1 = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            c1 = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            double py = (a1 + b1 + c1) / 2.0;
            double areay = Math.Sqrt(py*(py-a1)*(py-b1)*(py-c1));
            System.Console.WriteLine("Area de y = {0}",areay.ToString("f4",CultureInfo.InvariantCulture));
            if (areax > areay){
                System.Console.WriteLine("Area de x é maior");
            }
            else{
                System.Console.WriteLine("Area de y é maior");
            }
        }
    }
}
