using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = Console.ReadLine();
            int epi = int.Parse(Console.ReadLine());
            double poch = int.Parse(Console.ReadLine());

            poch = poch - poch * 0.125 - poch * 0.25;

            if(poch >= epi)
            {
                Console.WriteLine($"You have enough time to watch {ime} and left with {Math.Ceiling(poch - epi)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {ime}, you need {Math.Ceiling(epi - poch)} more minutes.");
            }
        }
    }
}