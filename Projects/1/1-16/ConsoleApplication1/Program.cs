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
            //建立新物件
            Program newobject = new Program();

            //呼叫物件中的Cal方法，傳入string型態的參數
            Console.WriteLine(newobject.Cal("44", "13"));
            //呼叫物件中的Cal方法，傳入decimal型態的參數
            Console.WriteLine("數字相加後結果為：" + newobject.Cal(44, 13));
            Console.Read();
        }
        //建立回傳別為decimal的Cal方法，接受兩個decimal型別的參數
        decimal Cal(decimal x, decimal y)
        {
            //回傳結果
            return (x + y);
        }
        //建立回傳別為string的Cal方法，接受兩個string型別的參數
        string Cal(string x, string y)
        {
            //回傳結果
            return ("字串相加後結果為：" + (x + y));
        }
    }
}
