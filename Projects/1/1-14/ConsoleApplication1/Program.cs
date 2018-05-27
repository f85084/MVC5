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
            //宣告變數
            decimal x, y, result;
            Console.Write("請輸入被除數：");
            //使用者輸入被除數
            x = decimal.Parse(Console.ReadLine());
            Console.Write("請輸入除數：");
            //使用者輸入除數
            y = decimal.Parse(Console.ReadLine());

            //建立MyCal物件
            MyCal newCal = new MyCal();
            //呼叫MyCal物件中的Cal方法
            result = newCal.Cal(x, y);
            Console.WriteLine("{0}/{1}={2}", x, y, result);
            Console.Read();
        }
        //建立公開的 MyCal類別
        public class MyCal
        {
            //建立公開的Cal方法
            public decimal Cal(decimal x, decimal y)
            {
                //回傳計算結果
                return (x / y);
            }
        }
    }
}
