using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Написать метод, возвращающий минимальное из трёх чисел.*/

namespace lesson_2_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 8;
            var b = 15;
            var c = 7;

            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
            Console.ReadKey();
        }
    }
}
