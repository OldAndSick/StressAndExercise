using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve4
{
    class Program
    {
        static void Main(string[] args)
        {
            //요일 찾기 
            // 2007년 1월 1일은 월요일 x 월 y 일은 무슨 요일? 365일로 치고 1일은 월요일 7일을 일요일 반복 -> x월 x일이 365중 몇번째인지 알면 될듯?
            // 나누기 7 했을 때 나머지 0 -> 일, 1->월 ~ 6->토
            // x 값의 수에 따라 곱하기를 바꿈 

            int a1 = 31;
            int a2 = 28;
            int a3 = 31;
            int a4 = 30;
            int a5 = 31;
            int a6 = 30;
            int a7 = 31;
            int a8 = 31;
            int a9 = 30;
            int a10 = 31;
            int a11 = 30;
            int a12 = 31;

            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            int answer = 0;
            switch(a)
            {
                case 1:
                    answer = b % 7;
                    break;
                case 2:
                    answer = (a1 + b) % 7;
                    break;
                case 3:
                    answer = (a1 +a2 + b) % 7;
                    break;
                case 4:
                    answer = (a1 + a2 +a3+ b) % 7;
                    break;
                case 5:
                    answer = (a1 + a2 +a3+a4+ b) % 7;
                    break;
                case 6:
                    answer = (a1 + a2 +a3+a4+a5+ b) % 7;
                    break;
                case 7:
                    answer = (a1 + a2 + a3+a4+a5+a6+b) % 7;
                    break;
                case 8:
                    answer = (a1 + a2 +a3+a4+a5+a6+a7+ b) % 7;
                    break;
                case 9:
                    answer = (a1 + a2 +a3+a4+a5+a6+a7+a8+ b) % 7;
                    break;
                case 10:
                    answer = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8+a9 + b) % 7;
                    break;
                case 11:
                    answer = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 +a9+a10+ b) % 7;
                    break;
                case 12:
                    answer = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11+b) % 7;
                    break;

            }

            if(answer ==0)
            {
                Console.WriteLine("SUN");
            }
            else if(answer == 1)
            {
                Console.WriteLine("MON");
            }
            else if (answer == 2)
            {
                Console.WriteLine("TUE");
            }
            else if (answer == 3)
            {
                Console.WriteLine("WED");
            }
            else if (answer == 4)
            {
                Console.WriteLine("THU");
            }
            else if (answer == 5)
            {
                Console.WriteLine("FRI");
            }
            else if (answer == 6)
            {
                Console.WriteLine("SAT");
            }
        }
    }
}
