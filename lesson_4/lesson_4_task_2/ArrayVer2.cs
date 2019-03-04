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

namespace lesson_4_task_2
{
    class ArrayVer2
    {   
        public static int[] Array()
        {
            string inputPath = @"E:\GIT_projects\CSharp\lesson_4\lesson_4_task_1\data.txt";
            var fs = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            string content;

            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                content = reader.ReadToEnd();
            }

            //string[] numbers = content.Split(new char [] {' '});


            IEnumerable<int> values = content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            //foreach (var value in values)
            //{
            //    Console.WriteLine(value.ToString());
            //}

            //int[] arr = new int[numbers.Length-1];
            //int count = 0;
            //foreach (char ch in content)
            //{
            //    string temp = ch.ToString();
            //    arr[count] = int.Parse(temp);
            //    count++;

            //}
            return values;
        }

        static void Main(string[] args)
        {

            int[] arr = Array();

            int countThree = 0;
            
            for (int i = 0; i < arr.Length-1; i++)
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
