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
being driven to madness with fright.";

        public static string Text { get => text; set => text = value; }

        /// <summary>
        /// Метод выводит только те слова сообщения,  которые содержат не более n(5) букв
        /// </summary>
        /// <returns>Возвращает в консоль слова из 5 и более букв</returns>
        public static string TextAnalysis()
        {
            Regex regex = new Regex(@"[a-zA-Z]{5,}"); //Поиск слов длинной более 5 знаков

            string textFive = String.Empty;

            foreach (var item in regex.Matches(Text))
            {
                textFive += " " + item;
            }
            return textFive;
        }

        /// <summary>
        /// Удаляет из сообщения все слова, которые заканчиваются на (char ch = 'Символ') заданный символ.
        /// </summary>
        /// <returns>Возвращает форматированный текст</returns>
        public static string AnotherBreakIntTheWall()
        {
            char ch = 'h'; //

            StringBuilder result = new StringBuilder(Regex.Replace(text, "[^ ]{0,}" + ch + " ", "").Trim());
            string k = result.ToString();
            return k;
        }

        /// <summary>
        /// Метод ищет самое длинное слово в тексте
        /// </summary>
        /// <returns>Возвращает самое длинное слово</returns>
        public static string TextLongest()
        {
            Regex regex = new Regex(@"[a-zA-Z]{8,}"); //Считаю данное решение оптимальным посколько самых длинных слов может быть много.

            string textFive = String.Empty;

            foreach (var item in regex.Matches(Text))
            {

                textFive += " " + item;
            }
            return textFive;
        }

        /// <summary>
        /// Метод формирует строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <returns>Возвращает строку состояющую из самых длинных слов</returns>
        public static string TextStringBuilder()
        {
            StringBuilder a = new StringBuilder(text);
            //Console.WriteLine("Исходная строка: " + a);
            for (int i = 0; i < a.Length;)
                if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                else ++i;
            string str = a.ToString();
            string[] s = str.Split(' ');
            string result = String.Empty;
            //Console.WriteLine("Искомые слова: ");
            for (int i = 0; i < s.Length;)
            {
                if (s[i] == s[i + 1])
                {
                    // в процессе реализации 14-02 МСК
                }
                else ++i;
            }
            return result;
        }
    }
}
