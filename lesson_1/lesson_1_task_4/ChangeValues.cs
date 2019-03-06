using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    /*Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
    б) *без использования третьей переменной.*/

namespace lesson_1_task_4
{
    class ChangeValues
    {
        static void Main(string[] args)
        {
            //обмен с использованием 3й переменной
            var a = 10;
            var b = 20;
            var c = 0;

            c = a;a = b;b = c;

            //обмен двух переменных без использования 3й
            var x = 20;
            var w = 10;

            x = x + w;
            w = x - w;
            x = x - w;
        }
    }
}
