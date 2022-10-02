using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_4
{

    /*
    Задание №5: 
    Создайте массив А[1..7] с помощью генератора случайных чисел и выведите его на экран. Увеличьте все его элементы в 2 раза. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[7];
            FillArray(ref array);

            Console.WriteLine(" This is your array with {0} elements:", array.Length);
            DisplayArray(in array);

            ChangeArray(ref array);

            Console.WriteLine("\n This is your chaged array:");
            DisplayArray(in array);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();
            for (Int32 i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
        }

        static void ChangeArray(ref Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 2;
            }
        }
    }
}
