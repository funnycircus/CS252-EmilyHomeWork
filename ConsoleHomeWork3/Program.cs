using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randam = new Random();
            int randomNumber = randam.Next(0,2);
            Console.WriteLine("請輸入你的名字:");
            string Name = Console.ReadLine();
            string gender = (randomNumber == 0) ? "女" : "男";
            Console.WriteLine("我猜你是" + gender);
            Console.ReadLine();
        }
    }
}
