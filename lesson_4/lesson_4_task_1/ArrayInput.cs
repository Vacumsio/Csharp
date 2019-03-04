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
    public class ArrayInput
    {       
        public static bool FilePath(string path)
        {            
            try
            {
                string _path = path;
                Console.WriteLine("Искомый файл существует");
                return true;
            }
            catch (FormatException ex)
            { Console.WriteLine(ex.Message); return false; }
        }

        public static int[] Array()
        {                        
            string inputPath = @"data.txt";
            FilePath(inputPath);
            var fs = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            string content;

            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                content = reader.ReadLine();
            }

            string[] numbers = content.Split(new char[] { ' ' });
            int[] arr = new int[numbers.Length-1];

            for (int i = 0; i < numbers.Length-1; i++)
            {
                arr[i] = int.Parse(numbers[i]);
                i++;
            }
            return arr;
        }

        public static void LetTheMountainCome()
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
        }
    }
}
