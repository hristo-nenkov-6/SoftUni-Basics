using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            double taksa = double.Parse(Console.ReadLine());
            double kecove = taksa * 0.6;
            double ekip = kecove * 0.8;
            double topka = 0.25 * ekip;
            double akses = 0.2 * topka;

            double suma = taksa + kecove + ekip + topka + akses;
            Console.WriteLine(suma);
        }
    }
}
