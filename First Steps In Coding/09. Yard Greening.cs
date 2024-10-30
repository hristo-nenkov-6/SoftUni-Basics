using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sum = a * 7.61;
            Console.WriteLine("The final price is: " + (sum - sum * 0.18), 2 + " lv.");
            Console.WriteLine("The discount is: " + sum * 0.18 + " lv.");

        }
    }
}
