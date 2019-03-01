using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. 
 * Сами числа и сумму вывести на экран, используя tryParse.*/

namespace lesson_3_task_2
{
    class Program
    {
        static int value;
        static string console_message = "Введите число:";

        static int GetValue(string message)
        {
            int x;
            int summ = 0;
            bool success;
            do
            {
                Console.WriteLine(message);
                success = Int32.TryParse(Console.ReadLine(), out x);
                if (x % 2 != 0 && x > 0)
                {
                    summ += x;
                }
            } while (x!=0 || !success);
            return summ;
        }

        static void Main()
        {
            value = GetValue(console_message);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
