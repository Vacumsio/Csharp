using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить
работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.*/

namespace lesson_3_task_1
{
    class Program
    {    
        class Complex
        {
            public double a, b;

            public Complex(int v1, int v2)
            {
                this.a = v1;
                this.b = v2;
            }

            public static Complex Summ(Complex z1, Complex z2)
            {
                Complex res = new Complex(0,0);
                res.a = z1.a + z2.a;
                res.b = z1.b + z2.b;
                return res;
            }

            public static Complex Sub(Complex z1, Complex z2)
            {
                Complex res = new Complex(0,0);
                res.a = z1.a - z2.a;
                res.b = z1.b - z2.b;
                return res;
            }

            internal static Complex Plural(Complex z1, Complex z2)
            {
                Complex res = new Complex(0,0);
                res.a = z1.a * z2.a;
                res.b = z1.b * z2.b;
                return res;
            }

            public string ToString()
            {
                return $"{a} {b}";
            }
        }

        static void Main()
        {

            Complex z1 = new Complex(17, 11);
            Console.WriteLine($"z = {z1.a} + {z1.b}i");

            Complex z2 = new Complex(8, 13);

            Console.WriteLine($"z = {z2.a} + {z2.b}i");

            Complex z3 = Complex.Summ(z1, z2);
            //Console.WriteLine($"z = {z3.a} - {z3.b}i");

            Complex z4 = Complex.Sub(z1, z2);
            //Console.WriteLine($"z = {z4.a} - {z4.b}i");

            Complex z5 = Complex.Plural(z1, z2);
            //Console.WriteLine($"z = {z5.a} - {z5.b}i");

            Console.WriteLine($"Узнать сумму чисел введите: 1.\nУзнать разность чисел введите: 2.\nУзнать произведение чисел введите: 3.");
            
            int n;
            n = Int32.Parse(Console.ReadLine()); 
            switch (n)
            {
                case 1:
                    Console.WriteLine(z3.ToString());
                    break;
                case 2:
                    Console.WriteLine(z4.ToString());
                    break;
                case 3:
                    Console.WriteLine(z5.ToString());
                    break;
                default:
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
