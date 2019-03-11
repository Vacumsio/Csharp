using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{
    class Collections
    {
        static int StudentName(Student st1, Student st2)
        {
            return String.Compare(st1.firstName, st2.firstName);
        }
        static int StudentAge(Student st1, Student st2)
        {
            return st1.age.CompareTo(st2.age);
        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int bakalavr18 = 0;
            int magistr18 = 0;
            List<Student> list = new List<Student>();
            
            StreamReader sr = new StreamReader("students_4.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                    {
                        if (int.Parse(s[6]) < 5) bakalavr18++; else magistr18++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(StudentName));
            list.Sort(new Comparison<Student>(StudentAge));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров: {0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            Console.WriteLine("Магистров в возрасте от 18 до 20: {0}", magistr18);
            Console.WriteLine("Бакалавров в возрасте от 18 до 20: {0}", bakalavr18);
            foreach (var v in list) Console.WriteLine(v.age);
            foreach (var v in list) Console.WriteLine(v.firstName);
            
            Console.ReadKey();
        }
    }
}
