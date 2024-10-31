using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int spec = int.Parse(Console.ReadLine());
            for(int i = 1111; i <= 9999; i++)
            {
                int a1 = i / 1000;
                int a2 = (i / 100) % 10;
                int a3 = (i / 10) % 10;
                int a4 = i % 10;
                if(a1 > 0 && a2 > 0 && a3 > 0 && a4 > 0 && spec % a1 == 0 && spec % a2 == 0 && spec % a3 == 0 && spec % a4 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
}