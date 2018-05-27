using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static decimal Cal(decimal x, decimal y)
        {
            //回傳計算結果
            return (x / y);
        }
        static void Main(string[] args)
        {
            //宣告變數
            decimal x, y, result;
            Console.Write("請輸入被除數：");
            //使用者輸入被除數
            x = decimal.Parse(Console.ReadLine());
            Console.Write("請輸入除數：");
            //使用者輸入除數
            y = decimal.Parse(Console.ReadLine());

            //呼叫方法
            result = Cal(x, y);
            Console.WriteLine("{0}/{1}={2}", x, y, result);
            Console.Read();
        }
    }
}
