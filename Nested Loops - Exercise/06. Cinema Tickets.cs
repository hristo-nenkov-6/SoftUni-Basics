using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int FullStud = 0;
            int FullStand = 0;
            int FullKids = 0;
            double tickets = 0;
            string movie = Console.ReadLine();
            double mesta = int.Parse(Console.ReadLine());
            while (true)
            {
                int student = 0;
                int standart = 0;
                int kid = 0;
                string type = Console.ReadLine();
                double currentmesta = mesta;
                while (type != "End")
                {
                    if (type == "student") { student++; FullStud++; tickets++; }
                    else if (type == "standard") { standart++; FullStand++; tickets++; }
                    else if (type == "kid") { kid++; FullKids++; tickets++; }
                    currentmesta--;
                    if (currentmesta == 0) { break; }
                    type = Console.ReadLine();
                }
                Console.WriteLine($"{movie} - {(((student + standart + kid) / mesta) * 100):F2}% full.");
                movie = Console.ReadLine();
                if (movie == "Finish") { break; }
                mesta = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total tickets: {tickets}");
            Console.WriteLine($"{((FullStud / tickets) * 100):F2}" + "% student tickets.");
            Console.WriteLine($"{((FullStand / tickets) * 100):F2}" + "% standard tickets.");
            Console.WriteLine($"{((FullKids / tickets) * 100):F2}" + "% kids tickets.");

        }

    }
}