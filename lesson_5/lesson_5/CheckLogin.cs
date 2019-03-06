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
        /// <summary>
        /// Метод анализа логина не регулярными выражениями
        /// </summary>
        public void NonRegular()
        {
            string chekedLog = String.Empty;
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            char[] symbols = "!@#$%&?-+=~!@#$%&?-+=~!@#$%&?-+=~+=~".ToCharArray();

            Console.WriteLine("Введите логин");
            string log = Console.ReadLine();


            char[] ar = new char[log.Length];
            for (int i = 0; i < log.Length; i++)
            {
                ar[i] = log.ToUpper()[i];
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
                        int j = 0;
                        for (int i = 0; j < ar.Length; i++)
                        {
                            if (ar[j] == alphabet[i])
                            {
                                chekedLog += alphabet[i];
                                j++;
                                i = 0; i--;
                            }
                            else
                            {
                                if (ar[j] == symbols[i])
                                {
                                    Console.WriteLine("Логин содержит недопустимые значения");
                                    i = 0; i--; break;
                                }
                            }
                        }

                        if (chekedLog == log.ToUpper())
                        {
                            Console.WriteLine("Введенный логин удовлетворяет требованиям");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод анализа логина регулярными выражениями
        /// </summary>
        public void Regular()
        {
            Console.WriteLine("Введите логин");
            string userLogin = Console.ReadLine();
            Regex regex = new Regex(@"[^a-zA-Z0-9]");

            if (char.IsDigit(userLogin[0]))
            {
                Console.WriteLine("Первым симолом логина не может быть цифра");
            }
            else
            {
                if (userLogin.Length < 2 || userLogin.Length > 10)
                {
                    Console.WriteLine("Логин должен быть больше 2 и меньше 10 символов");
                }
                else
                {
                    if (regex.IsMatch(userLogin))
                    {
                        Console.WriteLine("Логин содержит недопустимые значения");
                    }
                    else
                    {
                        Console.WriteLine("Введенный логин удовлетворяет требованиям");
                    }
                }
            }
        }
    }
}

