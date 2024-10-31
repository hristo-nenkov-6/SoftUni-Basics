using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ime = Console.ReadLine();
            double obshto = 0;
            int br = 0;
            while(ime != "Finish")
            {
                double sredna = 0;
                for(int i = 0; i < n; i++)
                {
                    double ocenka = double.Parse(Console.ReadLine());
                    sredna += ocenka;
                    obshto += ocenka;
                    br++;
                }
                Console.WriteLine($"{ime} - {(sredna / n):F2}.");
                ime = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(obshto / br):F2}.");
        }

    }
}