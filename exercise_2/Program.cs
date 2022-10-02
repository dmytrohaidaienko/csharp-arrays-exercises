using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    /*
    Задание №2: 
    Введите с клавиатуры пять целочисленных элементов массива X. Выведите на экран значения корней и квадратов каждого из элементов массива.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[5];

            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" Please enter {i + 1} element in array: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (Int32 i = 0; i < array.Length; i++)
            {
                Double arraySqrt = Math.Sqrt(array[i]);
                Console.WriteLine($"Sqrt {i + 1} element: {arraySqrt}");

                Double arrayPow = Math.Pow(array[i], 2);
                Console.WriteLine($"Pow {i + 1} element: {arrayPow} \n");
            }
        }
    }
}
