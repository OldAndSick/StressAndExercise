using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve5
{
    class Program
    {
        static void Main(string[] args)
        {
            // x y z 를 구해야 함 , 답이 1개면 0, 여러개면 1, 존재 안하면 2
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int N = int.Parse(inputs[0]);
            int A = int.Parse(inputs[1]);
            int B = int.Parse(inputs[2]);
            int C = int.Parse(inputs[3]);
            int D = int.Parse(inputs[4]);
            int E = int.Parse(inputs[5]);
            int F = int.Parse(inputs[6]);
            int G = int.Parse(inputs[7]);
            int H = int.Parse(inputs[8]);

            int X = 0;
            int Y = 0;
            int Z = 0;

            int answer = 0;
            for(int i=0; i<=N; i++)
            {
                for(int k = 0; k<=N; k++)
                {
                    int zZ = N - i - k;
                    if(i<0 || k<0 || zZ <0)
                    {
                        break;
                    }
                    if((A*i)+(B*k)+(C* zZ) == D && (E * i) + (F * k) + (G* zZ) ==H)
                    {
                        answer++;
                        X = i;
                        Y = k;
                        Z = zZ;
                    }
                }
            }
            if (answer == 1)
            {
                Console.WriteLine("0");
                Console.Write($"{X} {Y} {Z}");
            }
            if(answer>1)
            {
                Console.WriteLine("1");
            }
            if(answer == 0)
            {
                Console.WriteLine("2");
            }
        }
    }
}
