using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    /*
    Задание №5
    Создайте массив А[1..8] с помощью генератора случайных чисел с элементами от –10 до 10 и выведите его на экран. Подсчитайте количество отрицательных элементов массива. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[8];

            FillArray(ref array);

            Console.WriteLine("Your array: ");
            DisplayArray(in array);

            UInt32 counter = 0;

            CountNegativeElement(in array, ref counter);
            Console.WriteLine("\n Amount of negative element in array: {0}", counter);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
        }

        static void CountNegativeElement(in Int32[] array, ref UInt32 counter)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    counter++;
            }
        }
    }
}
