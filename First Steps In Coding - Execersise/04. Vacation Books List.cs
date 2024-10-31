using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int str = int.Parse(Console.ReadLine());
            int per_hour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double hours = (str / per_hour) / days;
            Console.WriteLine(hours);
        }
    }
}
