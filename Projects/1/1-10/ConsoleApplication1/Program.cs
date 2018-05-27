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
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;//當i=3時，跳過不印
                }
                Console.Write(i + "\t");//印出i
            }
            Console.ReadLine();
        }
    }
}
