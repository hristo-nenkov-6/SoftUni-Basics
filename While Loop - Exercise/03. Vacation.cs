using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double MoneyNeeded = double.Parse(Console.ReadLine());
            double MoneyOwned = double.Parse(Console.ReadLine());
            int ConsequativeDays = 0;
            int days = 0;
            bool saved = true;

            while(MoneyOwned < MoneyNeeded)
            {
                string deed = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                if(deed == "spend")
                {
                    if(MoneyOwned < sum)
                    {
                        sum = MoneyOwned;
                    }
                    ConsequativeDays++;
                    MoneyOwned -= sum;
                }
                else
                {
                    MoneyOwned += sum;
                    ConsequativeDays = 0;
                }
                days++;
                if (ConsequativeDays == 5)
                {
                    saved = false;
                    break;
                }
            }

            if(saved == false)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }

        }
        
    }
}