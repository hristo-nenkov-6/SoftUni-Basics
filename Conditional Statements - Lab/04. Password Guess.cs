using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "s3cr3t!P@ssw0rd";
            string try_pass = Console.ReadLine();
            if(try_pass.Equals(pass))
            {
                Console.WriteLine("Welcome");
            }
            else { Console.WriteLine("Wrong password!"); }
        }
    }
}
