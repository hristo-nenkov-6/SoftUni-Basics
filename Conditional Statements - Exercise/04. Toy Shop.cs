using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.6, b = 3, c = 4.1, d = 8.2, e = 2;
            double cena = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine()); 
            double b1 = double.Parse(Console.ReadLine()); 
            double c1 = double.Parse(Console.ReadLine()); 
            double d1 = double.Parse(Console.ReadLine()); 
            double e1 = double.Parse(Console.ReadLine()); 
            double pechalba = (a * a1) + (b * b1) + (c * c1) + (d * d1) + (e * e1);

            if (a1 + b1 + c1 + d1 + e1 >= 50)
            {
                pechalba = pechalba * 0.75;
                pechalba = pechalba * 0.9;
            }
            else { pechalba = pechalba * 0.9; }

            if(pechalba >= cena)
            {
                Console.WriteLine($"Yes! {String.Format("{0:F2}", pechalba - cena)} lv left.");
            }
            else 
            { 
                Console.WriteLine($"Not enough money! {String.Format("{0:F2}", cena - pechalba)} lv needed."); }
        }
    }
}
