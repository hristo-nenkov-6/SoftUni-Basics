using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double razt = double.Parse(Console.ReadLine());
            double vreme = double.Parse(Console.ReadLine());

            double ivan_rec = razt * vreme;
            double zabav = Math.Floor(razt / 15);
            ivan_rec = ivan_rec + zabav * 12.5;

            if(ivan_rec < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {String.Format("{0:F2}", ivan_rec)}" +
                    $" seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {String.Format("{0:F2}", ivan_rec - record)} seconds slower.");
            }
        }
    }
}