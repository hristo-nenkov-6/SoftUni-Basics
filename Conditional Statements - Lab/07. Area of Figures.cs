using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();
            if(fig.Equals("square"))
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", a * a);
            }
            else if(fig.Equals("rectangle"))
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", a * b);
            }
            else if (fig.Equals("triangle"))
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (a * b) / 2);
            }
            else if (fig.Equals("circle"))
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", a * a * Math.PI); 
            }
        }
    }
}
