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
            string s;
            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                bool success = Int32.TryParse(s, out x);
                if (success)
                {
                    if (x % 2 != 0 && x > 0)
                    {
                        summ += x;
                        continue;
                    }
                    else
                    {
                        if (x % 2 == 0 && x > 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (x == 0) return summ;
                        }
                    }
                }
                else continue;
            } while (true);
        }

        static void Main()
        {
            value = GetValue(console_message);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
