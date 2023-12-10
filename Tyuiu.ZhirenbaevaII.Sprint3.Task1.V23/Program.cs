using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZhirenbaevaII.Sprint3.Task1.V23.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Жиренбаева И.И| ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Алгоритмы циклической структуры                                       ");
            Console.WriteLine(" Задание #1                                                             ");
            Console.WriteLine(" Вариант #23                                                           ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                              ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for                                   *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                          *");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("Переменная Х = " + value);
            Console.WriteLine("Старт шага  = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение рада = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
        
    
