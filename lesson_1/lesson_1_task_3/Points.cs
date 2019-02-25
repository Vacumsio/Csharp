using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
    * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
    * используя спецификатор формата .2f (с двумя знаками после запятой);
    б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/

namespace lesson_1_task_3
{
    class Points
    {
        static double distance(int x1,int x2, int y1, int y2)
        {
            return (double)Math.Sqrt((Math.Pow(x2-x1, 2)) + (Math.Pow(y2-y1, 2)));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Расстояние между казанными точками равно: "+ distance(x1,x2,y1,y2));
            Console.ReadKey();
        }
    }
}
