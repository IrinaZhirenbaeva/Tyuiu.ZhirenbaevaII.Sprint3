using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZhirenbaevaII.Sprint3.Task3.V16.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint3.Task3.V16
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
            Console.WriteLine(" Задание #3                                                             ");
            Console.WriteLine(" Вариант #16                                                           ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                    ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв “c” в строке ice      *");
            Console.WriteLine("* nice ice creamcc                                                        *");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");
            string value = "ice nice ice creamcc";
            char chr = 'c';

            Console.WriteLine(" Исходная строка = " + value);
            Console.WriteLine(" Искомый символ = " + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Количество символов = " + ds.GetCharCount(value, chr));

            Console.ReadKey();
        }
    }
    
}
