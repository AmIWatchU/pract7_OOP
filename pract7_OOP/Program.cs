using System;

namespace pract7_OOP
{
    class Program
    {
        //1. Сигнатура методу
        //  Завдання: Визначіть сигнатуру приведеного методу:
        //  int Summa(int a, int b = 0, int c = 0)
        //           {
        //                return a + b + c;
        //            }
        public static int Summa(int a, int b = 0, int c = 0)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            //Summa(int, int, int) - сигнатура метода 
            Console.WriteLine(Summa(4, 7, 2));
        }
    }
}
