using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint3.Task0.V17.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task0.V17
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
            Console.WriteLine(" Задание #0                                                              ");
            Console.WriteLine(" Вариант #17                                                           ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                              ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу используя цикл for, которая вычисляет сумму          ");
            Console.WriteLine(" ряда по формуле                                              ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            int v1 = 1;
            int v2 = 10;

            Console.WriteLine("Старт шага = " + v1);
            Console.WriteLine("Конец шага = " + v2);

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            double res = ds.GetSumSeries(v1, v2);
            Console.WriteLine("Сумма ряда = " + res);


            Console.ReadKey();
        }

    }
}

        
    

