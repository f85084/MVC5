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
            //利用for迴圈印出100以下的奇數
            for (int i = 1; i < 100; i = i + 2)
            {
                Console.Write(i + "\t");
            }
            Console.Read();
        }
    }
}
