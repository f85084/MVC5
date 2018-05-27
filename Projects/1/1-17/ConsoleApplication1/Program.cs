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
            int x, y, result;
            Console.Write("請輸入x：");
            //使用者輸入被除數
            x = int.Parse(Console.ReadLine());
            Console.Write("請輸入y：");
            //使用者輸入除數
            y = int.Parse(Console.ReadLine());

            //建立新物件
            MyAdd newCal = new MyAdd();
            //呼叫方法
            result = newCal.Cal(x, y);
            Console.WriteLine("{0}+{1}={2}", x, y, result);
            Console.Read();
        }
        //宣告 MyCal類別
        public class MyCal
        {
            //建立Cal方法此方法可被子類別覆寫
            public virtual int Cal(int x, int y)
            {
                //回傳計算結果
                return (x * y);
            }
        }
        //宣告 MyAdd類別，此類別繼承MyCal類別
        public class MyAdd : MyCal
        {
            //覆寫Cal方法
            public override int Cal(int x, int y)
            {
                //回傳計算結果
                return (x + y);
            }
        }
    }
}
