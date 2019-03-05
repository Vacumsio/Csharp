using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

/*
*/

namespace lesson_4
{
    public class ArrayInput
    {
        int[] array; //одномерный массив
        const int arraySize = 20;
        const int arrayStep = 3;
        Random r;

        public ArrayInput(int arraySize, int arrayStep)
        {
            array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * arrayStep;
            }
        }

        public ArrayInput()
        {
            array = new int[arraySize];
            r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = r.Next(-10000, 10000);
            }
        }
           
        public string Print1D()
        {
            string temp = String.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp += ($"{array[i]} ");
            }
            return temp;
        }

        public string Print2D()
        {
            string temp = String.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    temp += ($"{array[j]} ");
                }
                temp += "\n";
            }            
            return temp;
        }

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
            int[] arr = new int[numbers.Length-1];

            for (int i = 0; i < numbers.Length-1; i++)
            {
                arr[i] = int.Parse(numbers[i]);
                i++;
            }
            return arr;
        }

        public static int LetTheMountainCome()
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
            return countThree;            

        }
    }
}
