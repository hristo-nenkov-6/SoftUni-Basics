using System;

class Program
{
    static void Main() {
        string day = Console.ReadLine();
        int cena = 0;
        switch(day)
        {
            case "Monday":
            cena = 12;
            break;
            
             case "Tuesday":
            cena = 12;
            break;
            
             case "Wednesday":
            cena = 14;
            break;
            
             case "Thursday":
            cena = 14;
            break;
            
             case "Friday":
            cena = 12;
            break;
            
             case "Saturday":
            cena = 16;
            break;
            
             case "Sunday":
            cena = 16;
            break;
        }
        Console.WriteLine(cena);
    }
}