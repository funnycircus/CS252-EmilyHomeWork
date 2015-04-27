using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入四個整數");
            Console.WriteLine("第一個整數是:");
            string Number1 = Console.ReadLine();
            Console.WriteLine("第二個整數是:");
            string Number2 = Console.ReadLine();
            Console.WriteLine("第三個整數是:");
            string Number3 = Console.ReadLine();
            Console.WriteLine("第四個整數是:");
            string Number4 = Console.ReadLine();
            /*
            int Num1 = int.Parse(Number1);
            int Num2 = int.Parse(Number2);
            int Num3 = int.Parse(Number3);
            int Num4 = int.Parse(Number4);
            int Sum1 = Num1 + Num2;
            int Sum2 = Num3 + Num4;
            Console.WriteLine("第一個總合是:" + Sum1 + ", 第二個總合是:" + Sum2);
            */

            Console.WriteLine("第一個總合是:" + (int.Parse(Number1) + int.Parse(Number2))
                              + ", 第二個總合是:" + (int.Parse(Number3) + int.Parse(Number4)) );

        }
    }
}
