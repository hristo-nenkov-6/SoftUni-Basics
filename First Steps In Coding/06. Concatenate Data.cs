using System;

namespace HelloSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {name} {surname}, " +
                $"a {age}-years old person from {town}.");
        }
    }
}
