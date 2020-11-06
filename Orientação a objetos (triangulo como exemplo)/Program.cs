using System;
using System.Globalization;
namespace Orientação_a_objetos__triangulo_como_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
        Triangulo x,y;
        x = new Triangulo();
        y = new Triangulo();
        System.Console.WriteLine("Entre com as medidas do triangulo X: ");
        x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        System.Console.WriteLine("Entre com as medidas do triangulo Y: ");
        y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double areaX = x.Area();
        double areaY = y.Area();
        System.Console.WriteLine($"Area do triangulo X: {areaX.ToString("F3",CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Area do triangulo y: {areaY.ToString("F3",CultureInfo.InvariantCulture)}");
        if (areaX > areaY){
            System.Console.WriteLine("Area do triangulo x é maior");
        }
        else{
            System.Console.WriteLine("Area do triangulo y é maior");
        }
        }
    }
}
