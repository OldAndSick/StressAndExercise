using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int max = int.Parse(inputs[0]);
            int count = inputs.Length;
            for (int i = 0; i < count; i++)
            {
                int asd = int.Parse(inputs[i]);
                if (asd > max)
                {
                    max = asd;
                }
            }
            bool isEat = false;
            for(int i= 0; i<count-1; i++)
            {
                int abc = int.Parse(inputs[i]);
                if (max == abc)
                {
                    isEat = true;
                    break;
                }
            }
            //for (int i = count-1; i < count; i++)
            //{
            //    int abc = int.Parse(inputs[i]);
            //
            //    if (max == abc)
            //    {
            //        Console.WriteLine(max);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(max + 1);
            //        break;
            //    }
            //}
            if (isEat)
            {
                Console.WriteLine(max + 1);
            }
            else
            {
                Console.WriteLine(max);
            }
        }
    }
}
