using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());
            int igr = int.Parse(Console.ReadLine());
            double sum = 0;

            for(int i = 1; i <= age; i+=2)
            {
                sum += igr;
            }
            for(int i = 2; i <= age; i+=2)
            {
                sum = sum + 10 * (i / 2) - 1;
            }

            if (sum >= per)
            {
                Console.WriteLine($"Yes! {String.Format("{0:F2}", sum - per)}");
            }
            else { Console.WriteLine($"No! {String.Format("{0:F2}", per - sum)}"); }
            
        }
        
    }
}