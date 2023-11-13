using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Введите сторону квадрата a: ");
            //string tmp = Console.ReadLine();
            //int a = Int32.Parse(tmp);

            //int p = 4 * a;
            // Console.WriteLine("Периметр квадрата =" + p);


            //int s = a * a;
            //    Console.WriteLine("Площадь квадрата =" + s);

            //Console.WriteLine("hello, world!");

            Console.WriteLine("Введите два неотрицательных числа: ");
            string tmp = Console.ReadLine();
            int a = Int32.Parse(tmp);
            tmp = Console.ReadLine();
            int b = Int32.Parse(tmp);
            double result = Math.Sqrt(a * b);
                Console.WriteLine("Среднее геометрическое чисел = " + result);

        }
    }
}
