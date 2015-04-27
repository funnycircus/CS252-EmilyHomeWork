using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomeWorkEmily
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入您的名字:");
            string Name = Console.ReadLine();
            Console.WriteLine("請問你是男是女?");
            string Gender = Console.ReadLine();
            Console.WriteLine(Name + "你好!!");
            Console.WriteLine("我猜" + Name + "您一定是" + Gender + "!!");
        }
    }
}
