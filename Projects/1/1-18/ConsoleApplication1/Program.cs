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
            //宣告一Car類別物件物件
            Car car = new Car();
            //將car物件轉換成IMove介面物件
            IMove Im = (IMove)car;
            //呼叫實作的方法
            Im.Move();
            Console.ReadLine();
        }
    }
    //宣告一個介面IMove
    public interface IMove
    {
        //宣告一個方法，名稱為Move
        void Move();
    }
    //宣告一個類別Car，並實作IMove介面
    public class Car : IMove
    {
        //實作介面中的Move方法
        public void Move()
        {
            //顯示文字表示有實作方法
            Console.WriteLine("車子移動10公尺");
        }
    }
}
