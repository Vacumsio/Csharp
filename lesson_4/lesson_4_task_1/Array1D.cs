using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

/*
*/

namespace lesson_4
{
    public class Array1D
    {
        int[] array; //одномерный массив
        const int arraySize = 20;
        const int arrayStep = 3;
        Random r;

        /// <summary>
        /// Конструктор для создания одномерного массива с шагом
        /// </summary>
        /// <param name="arraySize">Размер массива</param>
        /// <param name="arrayStep">Шаг массива</param>
        public Array1D(int arraySize, int arrayStep)
        {
            array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * arrayStep;
            }
        }
                
        /// <summary>
        /// Конструктор для создания одномерного массива
        /// </summary>
        public Array1D()
        {
            array = new int[arraySize];
            r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = r.Next(-10000, 10000);
            }
        }

        /// <summary>
        /// Метод вывода на консоль значений созданного массива
        /// </summary>
        /// <returns>возвращает строковое значение</returns>        
        public string Print1D()
        {
            string temp = String.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp += ($"{array[i]} ");
            }
            return temp;
        }

        /// <summary>
        /// Метод считающий пары чисел с условием
        /// </summary>
        /// <returns>Возвращает подсчитанное число пар чисел, которые делятся на 3 без остатка</returns>
        public int CountThree()
        {
            int countThree = 0;

            for (int i = 0; i < array.GetLength(0)-1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 == 0)
                {
                    countThree++;
                }
            }
            return countThree;
        }      

    }
}
