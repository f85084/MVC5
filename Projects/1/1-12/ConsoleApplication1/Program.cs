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
            int[] index = new int[5];//宣告陣列，限定此陣列大小為5
            int data, del;//宣告兩個變數，data用來儲存新增的數字，del用來儲存刪除的數字
            for (int i = 0; i < 5; i++)//使用迴圈，執行次數為5次
            {
                Console.Write("請輸入第{0}個數字：", (i + 1));
                //將使用者輸入的字串轉換為整數並儲存至陣列中
                index[i] = int.Parse(Console.ReadLine());
            }
            List<int> result = index.ToList();//使用ToList方法將陣列轉換為List<TSource>型態
            Console.Write("請輸入一個數字新增至List集合中：");
            data = int.Parse(Console.ReadLine());//將使用者輸入的字串轉換為整數並由data變數儲存
            result.Add(data);//使用List的Add方法，將data整數新增至result尾端

            Console.Write("請輸入欲刪除的數字：");
            del = int.Parse(Console.ReadLine());//將使用者輸入的字串轉換為整數並由del變數儲存

            if (result.Contains(del))//使用List的Contains方法，判斷與del變數相符的元素是否存在
            {
                result.Remove(del);//使用List的Remove方法，刪除與del變數相符的元素
                Console.Write("刪除數字後該集合為：");
                for (int i = 0; i < result.Count; i++)//使用迴圈，執行次數與result元素數量相同
                {
                    Console.Write("{0}  ", result[i]);//將result集合中的資料印出
                }
                Console.Read();
            }
            else//若上述判斷為否則執行以下片段
            {
                Console.WriteLine("該數字不存在！");//印出數字不存在的訊息
                Console.Read();
            }
        }
    }
}
