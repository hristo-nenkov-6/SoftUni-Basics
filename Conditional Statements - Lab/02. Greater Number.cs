using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a > b)
            {
                Console.WriteLine(a);
            }
            else { Console.WriteLine(b); }
        }
    }
}
