using System;

namespace Solve
{
    class Program
    {
        static void Main(string[] args)
        {

            string testCase = Console.ReadLine();
            for (int i = 0; i < int.Parse(testCase); i++)
            {
                int asd = 1;
                string input = Console.ReadLine();
                string[] inputs = input.Split(' ');

                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                
                for (int k = 0; k < b; k++)
                {
                    asd = (asd * a) % 10;
                    if (asd == 0)
                    {
                        asd = 10;
                    }
                }
                Console.WriteLine(asd);
            }
        }
    }
}
