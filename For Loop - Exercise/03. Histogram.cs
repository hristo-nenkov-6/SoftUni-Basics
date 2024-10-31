using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int age = int.Parse(Console.ReadLine());
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

            if(sum >= per)
            {
                Console.WriteLine($"Yes! {String.Format("{0:F2}", sum - per)}");
            }
            else { Console.WriteLine($"No! {String.Format("{0:F2}", per - sum)}");*/
            int n = int.Parse(Console.ReadLine());
            int br1 = 0, br2 = 0, br3 = 0, br4 = 0, br5 = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 200) br1++;
                else if (x >= 200 && x < 400) br2++;
                else if (x >= 400 && x < 600) br3++;
                else if (x >= 600 && x < 800) br4++;
                else br5++;
            }
            double br = br1 + br2 + br3 + br4 + br5;
            Console.WriteLine("{0:F2}%", (double)(br1 * 100 / br));
            Console.WriteLine("{0:F2}%", (double)(br2 * 100 / br));
            Console.WriteLine("{0:F2}%", (double)(br3 * 100 / br));
            Console.WriteLine("{0:F2}%", (double)(br4 * 100 / br));
            Console.WriteLine("{0:F2}%", (double)(br5 * 100 / br));
        }
        
    }
}