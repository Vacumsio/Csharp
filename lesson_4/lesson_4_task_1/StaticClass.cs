using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    static class StaticClass
    {   
        /// <summary>
        /// Статический метод обрабатывающий одномерный массив с помощью метода Array1D CountThree()
        /// </summary>
        /// <returns>возвращает числовое значение пар чисел кратных 3</returns>
        public static int GetArray()
        {
            Array1D array = new Array1D();
            
            int count = array.CountThree();

            return count;
        }

        /// <summary>
        /// Статический метод для считывания массива из текстового файла
        /// </summary>
        /// <returns>Возвращает массив целых чисел</returns>
        public static int[] Array()
        {
            string inputPath = @"data.txt";

            var fs = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            string content;

            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                content = reader.ReadLine();
            }

            string[] numbers = content.Split(new char[] { ' ' });
            int[] arr = new int[numbers.Length - 1];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                arr[i] = int.Parse(numbers[i]);
                i++;
            }
            return arr;
        }
    }
}
