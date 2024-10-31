using System;

class Program
{
    static void Main() {
        string prod = Console.ReadLine();
        string prom;
        switch(prod)
        {
            case "banana":
            prom = "fruit";
            break;
            
            case "apple":
            prom = "fruit";
            break;
            
            case "kiwi":
            prom = "fruit";
            break;
            
            case "cherry":
            prom = "fruit";
            break;
            
            case "lemon":
            prom = "fruit";
            break;
            
            case "grapes":
            prom = "fruit";
            break;
            
            case "tomato":
            prom = "vegetable";
            break;
            
            case "cucumber":
            prom = "vegetable";
            break;
            
            case "pepper":
            prom = "vegetable";
            break;
            
            case "carrot":
            prom = "vegetable";
            break;
            
            default:
            prom = "unknown";
            break;
        }
        Console.WriteLine(prom);
    }
}