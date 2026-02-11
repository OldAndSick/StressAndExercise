using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력한 값의 나누기 4를하고 나온 수만큼 long을 출력
            int push = int.Parse(Console.ReadLine());
            int a = push / 4;
            
            for(int i = 0; i<a; i++)
            {
                Console.Write("long ");
            }
            Console.Write("int");


        }
    }
}
