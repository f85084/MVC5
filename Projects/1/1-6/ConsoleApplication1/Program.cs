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
            string[] nameList = { "張三", "李四", "王五" };
            foreach (string name in nameList)//將nameList的值全部列出
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
