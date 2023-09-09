using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int c = 0;
           
            double b = Math.PI;
            double value1, value2, value3, value4, value5;     // Задаем переменные
          
            // разделяем пример на дествиия
            value1 = (3 * (Math.Log(8, a)));                   // действие 1    
           
         value2 = ( Math.Sin(b / (3 * a)));                    // действие 2

            value3 = Math.Cbrt(5 * (Math.Pow(a, 2)) + 7);      // действие 3
            value4 = 4 *  Math.Abs(c - (2 * a) + 1);          // действие 4
            value5 = Math.Sqrt(8*a);                          // действие 5
            double result = (value1 / value2) - (value3 ) + (value4 / value5);   // складываем все результаты
           double finish =  Math.Round(result, 0 );           // округляем
            Console.WriteLine(finish);                        //выводим результат на консоль




            Console.ReadLine();




        }
    }
    
}