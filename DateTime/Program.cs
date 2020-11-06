using System;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
           // DateTime d1 = new DateTime(2020,10,21);
              DateTime d2 = DateTime.UtcNow;
            //System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
            TimeSpan d3 = new TimeSpan(0,1,30);
            System.Console.WriteLine(d3);
            System.Console.WriteLine(d3.Ticks);

        }
    }
}
