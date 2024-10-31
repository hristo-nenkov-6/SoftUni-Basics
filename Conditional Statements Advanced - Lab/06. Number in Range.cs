using System;

class Program
{
    static void Main() {
            string prod = Console.ReadLine();
            string grad = Console.ReadLine();
            double kol = double.Parse(Console.ReadLine());
            double cena = 0;
            
            if(grad == "Sofia")
            {
                if(prod == "coffee")
                {
                    cena = 0.5;
                }
                else if(prod == "water")
                {
                    cena = 0.8;
                }
                else if(prod == "beer")
                {
                    cena = 1.2;
                }
                else if(prod == "sweets")
                {
                    cena = 1.45;
                }
                else
                {
                    cena = 1.6;
                }
            }
            
            else if(grad == "Plovdiv")
            {
                if(prod == "coffee")
                {
                    cena = 0.4;
                }
                else if(prod == "water")
                {
                    cena = 0.7;
                }
                else if(prod == "beer")
                {
                    cena = 1.15;
                }
                else if(prod == "sweets")
                {
                    cena = 1.3;
                }
                else
                {
                    cena = 1.5;
                }
            }
            
            else 
            { 
                if(prod == "coffee")
                {
                    cena = 0.45;
                }
                else if(prod == "water")
                {
                    cena = 0.7;
                }
                else if(prod == "beer")
                {
                    cena = 1.1;
                }
                else if(prod == "sweets")
                {
                    cena = 1.35;
                }
                else
                {
                    cena = 1.55;
                }
            }
            Console.WriteLine(kol * cena);
    }
}