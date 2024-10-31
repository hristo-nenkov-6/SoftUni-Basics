using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            string favbook = Console.ReadLine();
            bool isfound = false;
            string chosen = Console.ReadLine();

            while(chosen != "No More Books")
            {
                if(chosen == favbook)
                {
                    isfound = true;
                    break;
                }
                br++;
                chosen = Console.ReadLine();
            }

            if(isfound == true)
            {
                Console.WriteLine($"You checked {br} books and found it.");
            }
            else 
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {br} books.");
                    }
        }
        
    }
}