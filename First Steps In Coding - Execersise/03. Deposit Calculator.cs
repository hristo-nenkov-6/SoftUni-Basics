using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep_suma = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double lih = double.Parse(Console.ReadLine());
            double lih_per = lih / 100;
            double new_suma = dep_suma + srok * ((dep_suma * lih_per) / 12);
            Console.WriteLine(new_suma);
        }
    }
}
