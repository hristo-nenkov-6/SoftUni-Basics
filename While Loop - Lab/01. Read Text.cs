using System;

class Program
{
    static void Main() {
        while(true)
        {
            string input = Console.ReadLine();
            if(input == "Stop") { break; }
            Console.WriteLine(input);
        }
    }
}