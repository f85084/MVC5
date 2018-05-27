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
            decimal x; //被除數
            decimal y; //除數
            decimal result; //運算結果

            try//正常執行時的程式碼片段
            {
                Console.Write("請輸入被除數：");
                x = decimal.Parse(Console.ReadLine()); //使用者輸入被除數轉換成decimal型態

                Console.Write("請輸入除數：");
                y = decimal.Parse(Console.ReadLine()); //使用者輸入除數轉換成decimal型態

                result = (x / y); //將計算結果以變數儲存
                Console.WriteLine("{0}除以{1}的結果為：{2}", x, y, result); //顯示結果至使用者端
            }
            catch (Exception ex)//錯誤發生時所執行的程式碼
            {
                Console.WriteLine("錯誤!錯誤訊息為：{0}", ex); //顯示錯誤訊息至使用者端
            }
            finally
            {
                Console.Write("執行完成!");
                Console.Read();
            }
        }
    }
}
