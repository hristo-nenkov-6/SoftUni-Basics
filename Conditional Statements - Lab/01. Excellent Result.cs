using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if(grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
