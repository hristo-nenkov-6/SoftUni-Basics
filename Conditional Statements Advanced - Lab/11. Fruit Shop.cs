using System;

class Program
{
    static void Main() {
        int ch = int.Parse(Console.ReadLine());
        if((ch < 100 || ch > 200) && ch!= 0)
        {
            Console.WriteLine("invalid");
        }
    }
}