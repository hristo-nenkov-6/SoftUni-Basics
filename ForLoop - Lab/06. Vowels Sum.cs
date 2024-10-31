using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int sum = 0;
            for(int i = 0; i < inp.Length; i++)
            {
                switch(inp[i])
                {
                    case 'a':
                        sum += 1;
                        break;

                    case 'e':
                        sum += 2;
                        break;

                    case 'i':
                        sum += 3;
                        break;

                    case 'o':
                        sum += 4;
                        break;

                    case 'u':
                        sum += 5;
                        break;

                    default: break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}