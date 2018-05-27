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
            int i = 31;
            //如果i除以2的餘數為0，則為偶數。否則為奇數
            Console.WriteLine((i % 2 == 0) ? "此為偶數" : "此為奇數");
            Console.Read();
        }
    }
}
