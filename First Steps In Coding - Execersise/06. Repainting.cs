using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razr = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());

            int _nailon = nailon + 2;
            double _boq = boq * 1.1;
            double torb = 0.4;

            double suma = _nailon * 1.5 + _boq * 14.5 + 5 * razr + torb;
            double maist = suma * 0.3 * chasove;

            double obshto = suma + maist;

            Console.WriteLine(obshto);
        }
    }
}
