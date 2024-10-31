using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double acad = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string ocen = Console.ReadLine();
                int dul = ocen.Length;
                double toch = double.Parse(Console.ReadLine());
                acad = acad + (toch * dul) / 2;
                if (acad > 1250.5)
                    break;
            }
            if (acad > 1250.5)
            {
                Console.WriteLine($"Congratulations, " +
                    $"{name} got a nominee " +
                    $"for leading role with {String.Format("{0:F1}", acad)}!");
            }
            else { Console.WriteLine($"Sorry, {name} you need {String.Format("{0:F1}", 1250.5 - acad)} more!"); }

        }
        
    }
}