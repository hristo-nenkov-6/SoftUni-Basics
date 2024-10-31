using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int dul = int.Parse(Console.ReadLine());
            int shir = int.Parse(Console.ReadLine());
            int vis = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());

            double obem = (double)(dul * shir * vis) / 1000;
            double aks = (per / 100);

            double voda = obem * (1 - aks);

            Console.WriteLine(voda);
        }
    }
}
