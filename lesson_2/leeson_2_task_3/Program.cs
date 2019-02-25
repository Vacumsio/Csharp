using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 * (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
 * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
*/

namespace leeson_2_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryies = 0;
            string log = "login";
            string psw = "geekbrains";

            do
            {
                Console.WriteLine("Введите логин: ");
                var userLog = Console.ReadLine();
                if (log == userLog.ToLower())
                {
                    Console.WriteLine("Веедите пароль: ");
                    var userPsw = Console.ReadLine();
                    if (psw == userPsw.ToLower())
                    {
                        Console.WriteLine("Введенные данные корректны. Добро Пожаловать!");
                        Console.ReadKey();
                        break;
                    }
                    else Console.WriteLine("Неверно указан Логин."); tryies++; continue;
                }
                else Console.WriteLine("Неверно указан Логин."); tryies++; continue;

                
            } while (tryies < 3);
        }
    }
}
