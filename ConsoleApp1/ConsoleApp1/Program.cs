using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test");
            int num = 0;
            for (int i = 0; i < 10; i++)
            {
                num += num;
            }
            Console.WriteLine(num);

            Console.WriteLine("ASDASDASD");
        }
    }
}
