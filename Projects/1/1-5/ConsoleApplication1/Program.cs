using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)//代表乘數
            {
                for (int j = 2; j < 10; j++)//代表被乘數
                {
                    Console.Write(string.Format("{0}*{1}={2:00}\t", j, i, j * i));
                    if (j == 9)//印到被乘數為九時，換行
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.Read();
        }
    }
}
