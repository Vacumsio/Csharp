using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

/*2.Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.
*/

namespace lesson_4
{
    class ArrayInput
    {
        public static int[] Array()
        {
            try
            {
                string inputPath = @"E:\GIT_projects\CSharp\lesson_4\lesson_4_task_1\data.txt";
                var fs = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
                string content;

                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    content = reader.ReadLine();
                }

                string[] numbers = content.Split(new char[] { ' ' });
                int[] arr = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    arr[i] = int.Parse(numbers[i]);
                    i++;
                }
                return arr;
            }
            catch(FormatException ex)
            { Console.WriteLine(ex.Message); }            
        }

        static void New()
        {

            int[] arr = Array();

            int countThree = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 && arr[i + 1] % 3 == 0)
                {
                    countThree++;
                }
            }
            Console.WriteLine($"В данном массиве {countThree} пар чисел");
            Console.ReadKey();
        }
    }
}
