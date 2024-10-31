using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double resto = coins * 100;
            int br=0;
            while(resto >= 200)
            {
                resto -= 200;
                br++;
            }
            while (resto >= 100)
            {
                resto -= 100;
                br++;
            }
            while (resto >= 50)
            {
                resto -= 50;
                br++;
            }
            while (resto >= 20)
            {
                resto -= 20;
                br++;
            }
            while (resto >= 10)
            {
                resto -= 10;
                br++;
            }
            while (resto >= 5)
            {
                resto -= 5;
                br++;
            }
            while (resto >= 2)
            {
                resto -= 2;
                br++;
            }
            while (resto >= 1)
            {
                resto -= 1;
                br++;
            }
            Console.WriteLine(br);
        }

    }
}