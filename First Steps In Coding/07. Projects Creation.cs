using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int num_proj = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need " +
                $"{num_proj * 3} hours to complete " +
                $"{num_proj} project/s.");
        }
    }
}
