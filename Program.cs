using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
          
    /*1.	Пользователь вводит число секунд. Перевести секунды в часы, минуты, секунды.
    2.	Пользователь вводит длину окружности L. Найти радиус такой окружности.
    3.	Пользователь вводит трехзначное целое число. Найти сумму цифр данного числа. Например, введено 123. Программа выводит сумму цифр = 6.
    */
            double  L, R;
            int  a, b = 0;

            Console.Write("\nЗадача 2 \nВведите длину окружности: ");
            L = double.Parse(Console.ReadLine());
            R = L/(2 * Math.PI);
            Console.WriteLine("Радиус окружности = {0}", R);

            Console.Write("\nЗадача 3 \nВведите число: ");
            a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                b += a % 10;   
                a = a / 10;
            }
            Console.WriteLine("Сумма цифр = {0}", b);
            //Console.WriteLine("До свидания");


        }
    }
}
