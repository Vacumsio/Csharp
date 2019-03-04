using System;
using System.IO;
using System.Text;

/*1.Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
 * Заполнить случайными числами. 
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
 * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
 
    2.Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.

    3.а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера 
 * и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает 
 * сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива 
 * (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
е[заменить на в)]) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
     */

namespace lesson_4
{
    public static class Array
    {
        public static int[] MakeArray(int a, int x)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i*x;
                Console.WriteLine($"{arr[i]}");
            }
            return arr;
        }

        public static int[] MakeArray(int a)
        {
            int[] arr = new int[a];
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

        public static void Main(string[] args)
        {
            int [] arr = MakeArray(20);
            int count = CountThree(arr);
            Console.WriteLine($"В данном массиве {count} пар чисел");
            
            StringBuilder sb = new StringBuilder(arr.Length);
            foreach (int i in arr)
            {
                sb.Append($"{ i} ");
            }            
            Console.WriteLine(sb.ToString());

            StreamWriter file = new StreamWriter(@"data.txt");
            file.WriteLine(sb);
            file.Close();       
            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("2nd task");

            ArrayInput.LetTheMountainCome();

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("3rd task");
            int[] arrStep = MakeArray(20,3);

            Console.ReadKey();
        }
    }
}
