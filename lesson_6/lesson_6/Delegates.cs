using System;

namespace lesson_6
{
    public delegate double Fun(double a, double x);

    class Delegates
    {
        /// <summary>
        /// Метод производит расчет полученных от методов MyFunc && Sinus значений
        /// </summary>
        /// <param name="F"></param>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <param name="b"></param>
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        /// <summary>
        /// Метод-демнстрация работы метода a*x^2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns>Передает значения методу Table</returns>
        public static double MyFunc(double a, double x)
        {
            double y = a * x;
            return Math.Pow(y, x);
        }
        /// <summary>
        /// Метод-демнстрация работы метода a*sin(x)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns>Передает значения методу Table</returns>
        public static double Sinus(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
