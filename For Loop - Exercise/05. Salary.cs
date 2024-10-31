using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());
            double sal = double.Parse(Console.ReadLine());
            double oldsal = sal;
            int globa = 0;

            for(int i = 0; i < tab; i++)
            {
                string site = Console.ReadLine();
                switch(site)
                {
                    case "Facebook":
                        globa = 150;
                        break;

                    case "Instagram":
                        globa = 100;
                        break;

                    case "Reddit":
                        globa = 50;
                        break;

                    default:
                        globa = 0;
                        break;
                }
                sal = sal - globa;
                if (sal <= 0) break;
            }

            if(sal > 0)
            {
                Console.WriteLine(sal);
            }
            else { Console.WriteLine("You have lost your salary."); }
        }
        
    }
}