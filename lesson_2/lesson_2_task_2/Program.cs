using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Написать метод подсчета количества цифр числа.*/

namespace lesson_2_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число: ");
            Console.WriteLine("Количество знаков: " + count(Console.ReadLine()));
            Console.ReadKey();
        }

        static int count(string s)
        {
            return s.Length;
        }
    }
}
