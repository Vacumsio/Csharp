using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/

namespace lesson_2_task_3
{
    class Program
    {
        static int count(int s)
        {
            
            return s;
        }

        static void Main(string[] args)
        {
            int x;
            int s = 0;
            Console.WriteLine("Введите число");        
                do
                {
                    string str = Console.ReadLine();
                    x = Convert.ToInt32(str);
                    if (x % 2 != 0) s = +x;
                    else
                    {
                        if (x == 0)
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                } while (x != 0 || x<0);
        }
    }
}
