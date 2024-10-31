using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();
            int prime = 0, nprime = 0;
            while(ch != "stop")
            {
                if ((int.Parse(ch) == 2 || int.Parse(ch) == 3) || (int.Parse(ch) > 0 && int.Parse(ch) % 2 != 0 && int.Parse(ch) % 3 != 0 && int.Parse(ch) % 5 != 5))
                {
                    prime += int.Parse(ch);
                }
                else if (int.Parse(ch) < 0) { Console.WriteLine("Number is negative."); }
                else { nprime += int.Parse(ch); }
                ch = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nprime}");
        }

    }
}