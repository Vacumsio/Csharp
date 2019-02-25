using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

namespace lesson_1_task_2
{
    class IndexBodymass
    {
        static double bmi(double m, double h)
        {
            h = h / 100;
            return m / (h * h);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Для посчета индекса массы тела небоходимы ваши данные");
            Console.WriteLine("Укажиет ваш полный вес в кг");
            string x = Console.ReadLine();
            double weight = Convert.ToDouble(x);
            Console.WriteLine("Укажите ваш рост  в сантиметрах");
            string w = Console.ReadLine();
            double height = Convert.ToDouble(w);
            double i = bmi(weight,height);
            Console.WriteLine("Инедекс массы тела равен: " + i);
            Console.ReadKey();
        }
    }
}