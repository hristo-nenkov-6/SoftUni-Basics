using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //dekor e 10%
            //>150 stat - otst 10%

            double bud = double.Parse(Console.ReadLine());
            int broi = int.Parse(Console.ReadLine());
            double cena = double.Parse(Console.ReadLine());

            double oblek = broi * cena;
            bud = bud * 0.9;

            if(broi > 150)
            {
                oblek = oblek * 0.9;
            }

            double ost_pari = bud - oblek;

            if(ost_pari >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {String.Format("{0:F2}", ost_pari)} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {String.Format("{0:F2}", Math.Abs(ost_pari))} leva more.");
            }
        }
    }
}