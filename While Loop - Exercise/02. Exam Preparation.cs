using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int badmarks = int.Parse(Console.ReadLine());
            string problem = Console.ReadLine();
            int mark = int.Parse(Console.ReadLine());
            bool good = false;
            int br = 0;
            int sum = mark;
            string prevprob = "";
            int zad = 1;

            while(true)
            {
                if (mark <= 4) br++;
                if (br == badmarks)
                {
                    good = true;
                    break;
                }

                prevprob = problem;
                problem = Console.ReadLine();
                if (problem == "Enough") break;
                mark = int.Parse(Console.ReadLine());
                sum += mark;
                zad++;
            }
            if(good == true)
            {
                Console.WriteLine($"You need a break, {badmarks} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {((double)sum / zad):F2}");
                Console.WriteLine($"Number of problems: {zad}");
                Console.WriteLine($"Last problem: {prevprob}");
            }

        }
        
    }
}