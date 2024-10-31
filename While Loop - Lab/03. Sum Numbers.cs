using System;

class Program
{
    static void Main() {
        int input = int.Parse(Console.ReadLine());
        int sum = 0;
        while(sum < input)
        {
            int try1 = int.Parse(Console.ReadLine());
            sum += try1;
        }
        Console.WriteLine(sum);
    }
}