using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            string steps = Console.ReadLine();
            int sum = 0;
            bool reached = false;
            if (steps != "Going home")
            {
                sum += int.Parse(steps);
                while (sum < goal)
                {
                    steps = Console.ReadLine();
                    if (steps == "Going home")
                    {
                        steps = Console.ReadLine();
                        sum += int.Parse(steps);
                        if (sum >= goal) { reached = true; }
                        break;
                    }
                    sum += int.Parse(steps);
                    if (sum >= goal) { reached = true; }
                }
            }
            else 
            {
                steps = Console.ReadLine();
                sum += int.Parse(steps);
                //if (sum >= goal) { reached = true; }
            }
            if(reached == true || sum >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sum - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - sum} more steps to reach goal.");
            }
        }

    }
}