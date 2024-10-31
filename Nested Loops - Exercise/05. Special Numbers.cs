using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bre = false;
            while(true)
            {
                string country = Console.ReadLine();
                if (country == "End") break;
                double price = double.Parse(Console.ReadLine());
                while(price > 0)
                {
                    string subrani = Console.ReadLine();
                    if (subrani == "End") { bre = true; break; }
                    price -= double.Parse(subrani);
                }
                if (bre == true) break;
                Console.WriteLine($"Going to {country}!");
            }
        }

    }
}