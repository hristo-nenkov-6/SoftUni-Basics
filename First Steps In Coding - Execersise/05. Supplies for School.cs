using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int him = int.Parse(Console.ReadLine());
            int mar = int.Parse(Console.ReadLine());
            int prep = int.Parse(Console.ReadLine());
            int ots = int.Parse(Console.ReadLine());

            double old_sum = him * 5.8 + mar * 7.2 + prep * 1.2;
            double sum = old_sum - old_sum * ots / 100;
            Console.WriteLine(sum);
        }
    }
}
