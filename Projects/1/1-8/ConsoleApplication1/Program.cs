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
            int i = 1;
            do//先做
            {
                Console.WriteLine(i);
                i = i + 1;
            } while (i < 1);//再判斷
            Console.ReadLine();
        }
    }
}
