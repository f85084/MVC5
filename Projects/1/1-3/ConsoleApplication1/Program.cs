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
            Console.WriteLine("炸醬專賣店");
            Console.WriteLine("1.炸醬麵");
            Console.WriteLine("2.自選菜單");
            Console.Write("請問您要點什麼?");
            string i = Console.ReadLine();
            switch (i)//比對接收到的值
            {
                case "1"://如果接收到的值是1，將執行以下程式
                    Console.WriteLine("炸醬麵，50元，謝謝惠顧");
                    break;
                case "2"://如果接收到的值是2，將執行以下程式
                    i = Console.ReadLine();
                    Console.WriteLine(i + "，100元，謝謝惠顧");
                    break;
                default://如果接收到其他值，將執行以下程式
                    Console.WriteLine("本店沒有第三選項");
                    break;
            }
            Console.ReadLine();
        }
    }
}
