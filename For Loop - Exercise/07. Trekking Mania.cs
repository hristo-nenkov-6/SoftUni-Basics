using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int musala = 0, monblon = 0, kili = 0, k2 = 0, everest = 0;
            for (int i = 0; i < n; i++)
            {
                int grupa = int.Parse(Console.ReadLine());
                if (grupa <= 5)
                {
                    musala += grupa;
                }
                else if (grupa > 5 && grupa < 13)
                {
                    monblon += grupa;
                }
                else if (grupa >= 13 && grupa < 26)
                {
                    kili += grupa;
                }
                else if (grupa >= 26 && grupa < 41)
                {
                    k2 += grupa;
                }
                else everest += grupa;
            }
            double obshto = musala + monblon + kili + k2 + everest;

            Console.WriteLine("{0:F2}%", musala * 100 / obshto);
            Console.WriteLine("{0:F2}%", monblon * 100 / obshto);
            Console.WriteLine("{0:F2}%", kili * 100 / obshto);
            Console.WriteLine("{0:F2}%", k2 * 100 / obshto);
            Console.WriteLine("{0:F2}%", everest * 100 / obshto);
        }

    }
}