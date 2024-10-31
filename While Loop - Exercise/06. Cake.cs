using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());

            int S = l * w;

            while(S > 0)
            {
                string piece = Console.ReadLine();
                if (piece == "STOP")
                {
                    break;
                }
                else
                {
                    S -= int.Parse(piece);
                }
            }
            if(S>0)
            {
                Console.WriteLine($"{Math.Abs(S)} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(S)} pieces more.");
            }
        }

    }
}