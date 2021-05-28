using System;

namespace Ex2
{
    class Program
    {
//        2. Максимальне з трьох чисел
//          Завдання: Напишіть програму, яка знаходить максимальне з трьох дробових чисел,
//          що вводяться з клавіатури, використовуючи перевантаження методу для пошуку
//          максимального з двох значень.

        static double Max(double a,double b,double c)
        {
            return Max(a, Max(b, c));
        }
        static double Max(double a, double b)
        {
            return Math.Max(a, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Enter number for x value:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for y value:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for z value:");
            Console.WriteLine("P.S. Enter 0 if you want find max of 2 numbers");
            double z = double.Parse(Console.ReadLine());

            if (z == 0)
                Console.WriteLine("Максимальне число: " + Max(x, y));
            else
                Console.WriteLine("Максимальне число: " + Max(x,y,z));
        }
    }
}
