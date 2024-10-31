using System;

class Program
{
    static void Main() {
        string prod = Console.ReadLine();
        string day = Console.ReadLine();
        double kol = double.Parse(Console.ReadLine());
        double cena = 0;
        
        if(day == "Monday"  || day == "Tuesday"  || day == "Wednesday"  ||
        day == "Thursday"  || day == "Friday")
        {
            switch(prod)
            {
                case "banana":
                cena = 2.5;
                break;
                
                case "apple":
                cena = 1.2;
                break;
                
                case "orange":
                cena = 0.85;
                break;
                
                case "grapefruit":
                cena = 1.45;
                break;
                
                case "kiwi":
                cena = 2.7;
                break;
                
                case "pineapple":
                cena = 5.5;
                break;
                
                case "grapes":
                cena = 3.85;
                break;
                
                default:
                cena = -1;
                break;
            }
        }
        else if(day == "Saturday" || day == "Sunday")
        {
            switch(prod)
            {
                case "banana":
                cena = 2.7;
                break;
                
                case "apple":
                cena = 1.25;
                break;
                
                case "orange":
                cena = 0.90;
                break;
                
                case "grapefruit":
                cena = 1.6;
                break;
                
                case "kiwi":
                cena = 3;
                break;
                
                case "pineapple":
                cena = 5.6;
                break;
                
                case "grapes":
                cena = 4.2;
                break;
                
                default:
                cena = -1;
                break;
            }
        }
        else {
            Console.WriteLine("error");
        }
        
        if(cena != -1 && cena != 0)
        {
            Console.WriteLine(String.Format("{0:0.00}", cena * kol));
        }
        else if(cena == -1)
        {
            Console.WriteLine("error");
        }
    }
}