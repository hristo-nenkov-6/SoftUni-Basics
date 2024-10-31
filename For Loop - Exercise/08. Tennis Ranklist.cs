using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            int tochki = int.Parse(Console.ReadLine());
            int br = 0;
            double NachalniTochki = tochki;

            for(int i = 0; i < broi; i++)
            {
                string etap = Console.ReadLine();
                switch(etap)
                {
                    case "W":
                        tochki += 2000;
                        br++;
                        break;

                    case "F":
                        tochki += 1200;
                        break;

                    case "SF":
                        tochki += 720;
                        break;

                    default: break;
                }
            }
            Console.WriteLine($"Final points: {tochki}");
            Console.WriteLine($"Average points: {Math.Floor((tochki - NachalniTochki) / broi)}");
            Console.WriteLine("{0:F2}%", (double)(br * 100)/broi);
        }
        
    }
}