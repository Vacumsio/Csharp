using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
 * нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/
namespace lesson_2_task_4
{
    class Program
    {
        #region Вариант А
        //static double bmi(double m, double h)
        //{
        //    h = h / 100;
        //    return m / (h * h);
        //}

        //static double data(double weight, double height)
        //{
        //    Console.WriteLine("Укажиет ваш полный вес в кг");
        //    string x = Console.ReadLine();
        //    double weight = Convert.ToDouble(x);
        //    Console.WriteLine("Укажите ваш рост  в сантиметрах");
        //    string w = Console.ReadLine();
        //    double height = Convert.ToDouble(w);
        //    double i = bmi(weight, height);
        //    return i;
        //}

        //static void Main(string[] args)
        //{
        //    string man = "м";
        //    string woman = "ж";
        //    Console.WriteLine("Для посчета индекса массы тела небоходимы ваши данныеn\nУкажите ваш пол: (М/Ж)");
        //    string gender = Console.ReadLine();
        //    if (man == gender.ToLower())
        //    {
        //        double index = data();
        //        Console.WriteLine("Инедекс массы тела равен: " + index);
        //        if (index < 20)
        //        {
        //            Console.WriteLine("У вас дефицит веса. Требуется донабор веса.");
        //            Console.ReadKey();
        //        }
        //        else
        //        {
        //            if (index >= 20 && 25 < index)
        //            {
        //                Console.WriteLine("Ваше здоровье в пределах нормы");
        //                Console.ReadKey();
        //            }
        //            else
        //            {
        //                if (index >= 25 && 30 < index)
        //                {
        //                    Console.WriteLine("Незначительный избыточный вес");
        //                    Console.ReadKey();
        //                }
        //                else
        //                {
        //                    if (index >= 30 && 40 < index)
        //                    {
        //                        Console.WriteLine("Вы страдаете ожирением");
        //                        Console.ReadKey();
        //                    }
        //                    else
        //                    {
        //                        if (index >= 40)
        //                        {
        //                            Console.WriteLine("Вы страдаете опасной степенью ожирения. Это опасно для здоровь необходимо обратиться к врачу.");
        //                            Console.ReadKey();
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        Console.ReadKey();
        //    }
        //    if (woman == gender.ToLower())
        //    {
        //        double index = data();
        //        Console.WriteLine("Инедекс массы тела равен: " + index);
        //        if (index < 19)
        //        {
        //            Console.WriteLine("У вас дефицит веса. Требуется донабор веса.");
        //            Console.ReadKey();
        //        }
        //        else
        //        {
        //            if (index >= 19 && 24 < index)
        //            {
        //                Console.WriteLine("Ваше здоровье в пределах нормы");
        //                Console.ReadKey();
        //            }
        //            else
        //            {
        //                if (index >= 24 && 30 < index)
        //                {
        //                    Console.WriteLine("Незначительный избыточный вес");
        //                    Console.ReadKey();
        //                }
        //                else
        //                {
        //                    if (index >= 30 && 40 < index)
        //                    {
        //                        Console.WriteLine("Вы страдаете ожирением");
        //                        Console.ReadKey();
        //                    }
        //                    else
        //                    {
        //                        if (index >= 40)
        //                        {
        //                            Console.WriteLine("Вы страдаете опасной степенью ожирения. Это опасно для здоровь необходимо обратиться к врачу.");
        //                            Console.ReadKey();
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        #endregion
        #region Вариант Б
        static double bmi(double m, double h)
        {
            h = h / 100;
            return m / (h * h);
        }

        static void Main(string[] args)
        {
            string man = "м";
            string woman = "ж";

            Console.WriteLine("Для посчета индекса массы тела небоходимы ваши данныеn\nУкажите ваш пол: (М/Ж)");
            string gender = Console.ReadLine();

            Console.WriteLine("Укажиет ваш полный вес в кг");
            string x = Console.ReadLine();
            double weight = Convert.ToDouble(x);

            Console.WriteLine("Укажите ваш рост  в сантиметрах");
            string w = Console.ReadLine();
            double height = Convert.ToDouble(w);

            if (man == gender.ToLower())
            {
                double i = bmi(weight, height);
                int index = Convert.ToInt32(i);
                Console.WriteLine("Инедекс массы тела равен: " + index);
                if (index < 20)
                {
                    Console.WriteLine("У вас дефицит веса. Требуется донабор веса.");
                    Console.WriteLine($"Ваш вес составляет: {weight}, для перехода в группу Норма требуется донабрать {(120-weight)/2}");
                    Console.ReadKey();
                }
                else
                {
                    if (index >= 20 && 25 > index)
                    {
                        Console.WriteLine("Ваше здоровье в пределах нормы");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (index >= 25 && 30 > index)
                        {
                            Console.WriteLine("Незначительный избыточный вес");
                            Console.WriteLine($"Ваш вес составляет: {weight}, для перехода в группу Норма требуется снизить вес на {(120 - weight*2) / 2}");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (index >= 30 && 40 > index)
                            {
                                Console.WriteLine("Вы страдаете ожирением");
                                Console.WriteLine($"Ваш вес составляет: {weight}, для перехода в группу Норма требуется снизить вес на {(120 - weight*2) / 2}");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (index >= 40)
                                {
                                    Console.WriteLine("Вы страдаете опасной степенью ожирения. Это опасно для здоровь необходимо обратиться к врачу.");
                                    Console.WriteLine($"Ваш вес составляет: {weight}, для перехода в группу Норма требуется снизить вес на {(120 - weight*2) / 2}");
                                    Console.ReadKey();
                                }
                            }
                        }
                    }
                }
                Console.ReadKey();
            }
            if (woman == gender.ToLower())
            {
                double index = bmi(weight, height);
                Console.WriteLine("Инедекс массы тела равен: " + index);
                if (index < 19)
                {
                    Console.WriteLine("У вас дефицит веса. Требуется донабор веса.");
                    Console.ReadKey();
                }
                else
                {
                    if (index >= 19 && 24 > index)
                    {
                        Console.WriteLine("Ваше здоровье в пределах нормы");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (index >= 24 && 30 > index)
                        {
                            Console.WriteLine("Незначительный избыточный вес");
                            Console.WriteLine($"Ваш вес составляет: {weight}, для перехода в группу Норма требуется снизить вес на {(120 - weight * 2) / 2}");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (index >= 30 && 40 > index)
                            {
                                Console.WriteLine("Вы страдаете ожирением");
                                Console.WriteLine($"Ваш вес составляет: {weight}, для перехода в группу Норма требуется снизить вес на {(120 - weight * 2) / 2}");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (index >= 40)
                                {
                                    Console.WriteLine("Вы страдаете опасной степенью ожирения. Это опасно для здоровь необходимо обратиться к врачу.");
                                    Console.WriteLine($"Ваш вес составляет: {weight}, для перехода в группу Норма требуется снизить вес на {(120 - weight * 2) / 2}");
                                    Console.ReadKey();
                                }
                            }
                        }
                    }
                }
            }
            #endregion
        }
    }
}

