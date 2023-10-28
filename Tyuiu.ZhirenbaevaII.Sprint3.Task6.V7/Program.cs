using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint3.Task6.V7.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task6.V7
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
            Console.WriteLine(" Задание #6                                                            ");
            Console.WriteLine(" Вариант #7                                                            ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine(" Напишите программу, которая ищет среди целых чисел,                         ");
            Console.WriteLine(" принадлежащих числовому отрезку [17, 26] сумму всех делителей                                                                        ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       ");
            Console.WriteLine("**");

            int startValue = 17;
            int stopValue = 26;

            Console.WriteLine("Начало отрезка =  " + startValue);
            Console.WriteLine("Конец отрезка =  " + stopValue);
          
            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
