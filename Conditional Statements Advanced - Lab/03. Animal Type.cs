using System;

class Program
{
    static void Main() {
        string a = Console.ReadLine();
        switch(a)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
                
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
                
            default:
                Console.WriteLine("unknown");
                break;
        }
        
    }
}