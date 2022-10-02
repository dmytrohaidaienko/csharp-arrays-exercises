using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    /*
    Задание №1: 
    Введите с клавиатуры в массив пять целочисленных значений. Выведите их в одну строку через запятую. Получите для массива среднее арифметическое.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[5];

            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Please enter {i + 1} element in array: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
}
