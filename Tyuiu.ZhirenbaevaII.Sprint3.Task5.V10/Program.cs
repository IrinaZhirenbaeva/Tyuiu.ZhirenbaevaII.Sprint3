using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint3.Task5.V10.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task5.V10
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
            Console.WriteLine(" Задание #5                                                             ");
            Console.WriteLine(" Вариант #10                                                             ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine(" вычислить сумму ряда, при Х=5                                                ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       ");
            Console.WriteLine("**");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Переменная Х =  " + x);
            Console.WriteLine("Старт шага первой суммы ряда= " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда= " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда= " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда= " + stopValue2);

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();

        }
    }
}

        
    

