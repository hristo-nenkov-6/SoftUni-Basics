using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double bud = double.Parse(Console.ReadLine());
            int vid = int.Parse(Console.ReadLine());
            int pro = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            int vid_cena = 250;
            double pro_cena = 0.35 * (vid_cena * vid); 
            double ram_cena = 0.1 * (vid_cena * vid);

            double obshto = vid * vid_cena + pro * pro_cena + ram * ram_cena;

            if (vid > pro)
            {
                obshto = obshto * 0.85;
            }

            if (bud >= obshto)
            {
                Console.WriteLine($"You have {String.Format("{0:F2}", bud - obshto)} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {String.Format("{0:F2}", obshto - bud)} leva more!");
            }
        }
    }
}