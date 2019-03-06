using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
	в) используя вывод со знаком $.*/

namespace level_1_task_1
{
    class Questionnaire
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Заполние небольшую анкету.");
            Console.WriteLine("Укажите ваше имя?");
            string name = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию?");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string x = Console.ReadLine();
            int age = Convert.ToInt32(x);

            Console.WriteLine("Имя: "+name+" Фамилия: "+surname+" Возраст: "+ age);

            Console.Write("Имя: " + name + " ");
            Console.Write("Фамилия: " + surname + " ");
            Console.WriteLine("Возраст: " + "{0:G}", age);

            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age}");
            Console.ReadKey();
        }
    }
}
