﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint3.Task4.V23.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Жиренбаева И.И| ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Алгоритмы циклической структуры                                      ");
            Console.WriteLine(" Задание #4                                                              ");
            Console.WriteLine(" Вариант #23                                                             ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine(" На отрезке, где x принимает значения от -5 до 5, вычислить значение     ");
            Console.WriteLine(" функции y=(cos(x)/x)+3 При х = 0 прервать цикл.   ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       ");
            Console.WriteLine("**");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            double res = ds.Calculate(startValue, stopValue);
            Console.WriteLine("Произведение ряда = " + res);


            Console.ReadKey();

        }
    }
}
