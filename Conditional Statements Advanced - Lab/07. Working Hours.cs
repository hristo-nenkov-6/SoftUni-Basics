using System;

class Program
{
    static void Main() {
        double ch = double.Parse(Console.ReadLine());
        if(ch >= -100 && ch <= 100 && ch != 0)
        {
            Console.WriteLine("Yes");
        }
        else {Console.WriteLine("No");}
    }
}