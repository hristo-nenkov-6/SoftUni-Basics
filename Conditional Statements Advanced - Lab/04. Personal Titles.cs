using System;

class Program
{
    static void Main() {
        double age = double.Parse(Console.ReadLine());
        string gen = Console.ReadLine();
        
        if(gen == "m")
        {
            if(age < 16)
            {
                Console.WriteLine("Master");
            }
            else { Console.WriteLine("Mr."); }
        }
        else
        {
            if(age < 16)
            {
                Console.WriteLine("Miss");
            }
            else { Console.WriteLine("Ms."); }
        }
    }
}