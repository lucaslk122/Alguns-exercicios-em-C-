using System;

namespace tipo_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite algum numero: ");
            int x = int.Parse(Console.ReadLine());
            string day;
            switch(x){
                case 1:
                    day = "Sunday";
                    break; //o swiitch-case necessita do break para parar a leitura dos casos e resotrnar o valor desejado
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;    
            }
            System.Console.WriteLine($"Day {day}");
        }
    }
}
