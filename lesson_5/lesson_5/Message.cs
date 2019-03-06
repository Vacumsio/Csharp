using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lesson_5
{

    static class Message
    {
        private static string text =
                        @"Through the ghoul-guarded gateways of slumber, 
                        Past the wan-mooned abysses of night, 
                        I have lived o'er my lives without number, 
                        I have sounded all things with my sight; 
                        And I struggle and shriek ere the daybreak, 
                        being driven to madness with fright.
                        В лунном свете минуя ворота
                        Снов, где нечисть проход стерегла,
                        Проживала я жизней без счёта,
                        Принимала личин без числа,
                        И безумно боялась кого-то,
                        И стенаний сдержать не могла.";
        public static string Text { get => text; set => text = value; }

        /// <summary>
        /// Метод выводит только те слова сообщения,  которые содержат не более n(5) букв
        /// </summary>
        /// <returns>Возвращает в консоль слова из 5 и более букв</returns>
        public static string TextAnalysis()
        {
            Regex regex = new Regex(@"[a-zA-Zа-яА-Я]{5,}"); //Поиск слов длинной более 5 знаков
            
            string textFive = String.Empty;

            foreach (var item in regex.Matches(Text))
            {
                textFive += " " + item;
            }
            return textFive;
        }


    }
}
