using System;
using System.IO;
using System.Text;

/*1.Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
 * Заполнить случайными числами. 
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
 * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. */

namespace lesson_4
{
    public static class Array
    {
        public static int[] MakeArray()
        {
            int[] arr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10000, 10000);
                Console.WriteLine($"{arr[i]}");
            }
            return arr;
        }

        public static int CountThree(int[] array)
        {
            int[] arr = array;
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

        static void Main(string[] args)
        {
            int [] arr = MakeArray();
            int count = CountThree(arr);
            Console.WriteLine($"В данном массиве {count} пар чисел");
            
            StringBuilder sb = new StringBuilder(arr.Length);
            foreach (int i in arr)
            {
                sb.Append($"{ i} ");
            }            
            Console.WriteLine(sb.ToString());

            StreamWriter file = new StreamWriter(@"E:\GIT_projects\CSharp\lesson_4\lesson_4_task_1\data.txt");
            file.WriteLine(sb);
            file.Close();       
            
            Console.ReadKey();
        }
    }
}
