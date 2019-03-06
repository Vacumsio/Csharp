using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.*/

#region TSK_3
namespace Fraction
{
    class Fraction
    {
        int Numerator;
        int Denominator;

        public Fraction(int N, int D)
        {
            if (D == 0)
            {
                throw new DivideByZeroException();
            }
            Numerator = N; Denominator = D;
        }

        public Fraction()
        {
            Numerator = 1; Denominator = 1;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator).Normalization();
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator).Normalization();
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator).Normalization();
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator, b.Numerator * a.Denominator).Normalization();
        }

        public Fraction Normalization()//Нормализация дроби
        {
            return new Fraction(Numerator / GetCommonDivisor(Numerator, Denominator), Denominator / GetCommonDivisor(Numerator, Denominator));
        }

        private static int GetCommonDivisor(int i, int j)//Алгоритм Евклида НОД
        {
            i = Math.Abs(i);
            j = Math.Abs(j);
            while (i != j)
                if (i > j) { i -= j; }
                else { j -= i; }
            return i;
        }

        public override string ToString()
        {
            int iPart = Numerator / Denominator;
            if (iPart != 0)
                return string.Format("{0} {1}", iPart, GetRest());
            else
                return string.Format("{0}/{1}", Numerator, Denominator);
        }

        public object GetRest()// остаток от выделения целой части
        {
            if (Numerator != Denominator)
            { return new Fraction(Numerator % Denominator, Denominator); }
            return null;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraction f1 = new Fraction(1, 3);
                Fraction f2 = new Fraction(2, 3);

                Console.WriteLine("Сложение дробей: {0} + {1} = {2}", f1, f2, f2 + f1);
                Console.WriteLine("Вычитание дробей: {0} + {1} = {2}", f1, f2, f2 - f1);
                Console.WriteLine("Умножение дробей: {0} + {1} = {2}", f1, f2, f2 * f1);
                Console.WriteLine("Деление дробей: {0} + {1} = {2}", f1, f2, f2 / f1);
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception caught:{0}", e.Message);
                Console.ReadKey();
            }
        }
    }
}
#endregion