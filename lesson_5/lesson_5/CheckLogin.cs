using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lesson_5
{
    class CheckLogin
    {
        public void NonRegular()
        {
            Console.WriteLine("Введите логин");
            string log = Console.ReadLine();
            log.ToUpper();

            char[] arr_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] arr_symb = "!@#$%&?-+=~".ToCharArray();

            char[] ar = new char[log.Length];
            for (int i = 0; i < log.Length;i++)
            {
                ar[i] = log[i];                
            }

            if (char.IsDigit(ar[0]))
            {
                Console.WriteLine("Первым симолом логина не может быть цифра");
            }
            else
            {
                if (log.Length < 2)
                {
                    Console.WriteLine("User Login is too small");
                }
                else
                {
                    if (log.Length > 10)
                    {
                        Console.WriteLine("User Login adjust max value");
                    }
                    else
                    {
                        if (ar==arr_EN)
                        {
                            Console.WriteLine("Логин содержит недопустимые значения");
                        }
                        else Console.WriteLine("Введенный логин удовлетворяет требованиям");
                    }
                }
            }
        }        

        public void Regular()
        {
            string pattern = @"{^[0-9][a-zA-Z0-9]}";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Введите логин");
            string userLogin = Console.ReadLine();

            foreach (bool item in regex.Matches(userLogin))
            {
                if (item)
                {
                    Console.WriteLine("Введенный логин удовлетворяет требованиям");
                }
                if (userLogin.Length < 2)
                {
                    Console.WriteLine("User Login is too small");
                }
                else
                {
                    if (userLogin.Length > 10)
                    {
                        Console.WriteLine("User Login adjust max value");
                    }
                    else
                    {
                        if (userLogin == pattern)
                        {
                            Console.WriteLine("Логин содержит недопустимые значения");
                        }
                        else Console.WriteLine("Введенный логин удовлетворяет требованиям");
                    }
                }

            }
        }
    }
}
