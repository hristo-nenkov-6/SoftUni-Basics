using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int pil = int.Parse(Console.ReadLine());
            int rib = int.Parse(Console.ReadLine());
            int veg = int.Parse(Console.ReadLine());
            double sum1 = pil * 10.35 + rib * 12.4 + veg * 8.15;
            double des = sum1 * 0.2;

            double obsht = sum1 + des + 2.5;
            Console.WriteLine(obsht);

        }
    }
}
