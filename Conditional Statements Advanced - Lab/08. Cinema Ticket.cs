using System;

class Program
{
    static void Main() {
        int chas = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();
        
        if(chas >= 10 && chas <= 18)
        {
            switch(day)
            {
                case "Monday":
                Console.WriteLine("open");
                break;
                
                case "Tuesday":
                Console.WriteLine("open");
                break;
                
                case "Wednesday":
                Console.WriteLine("open");
                break;
                
                case "Thursday":
                Console.WriteLine("open");
                break;
                
                case "Friday":
                Console.WriteLine("open");
                break;
                
                case "Saturday":
                Console.WriteLine("open");
                break;
                
                default:
                Console.WriteLine("closed");
                break;
            }
        }
        else { Console.WriteLine("closed"); }
    }
}