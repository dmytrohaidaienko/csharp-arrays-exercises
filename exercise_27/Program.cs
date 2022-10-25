using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_27
{

    /*
    Задание №27:
    Создать одномерный массив на 20 элементов. Используя метод сортировки "bubble-sort" отсортировать массив по убыванию.
    Заполнение массива выполнить случайными числами от -10 до 10.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[20];

            FillArray(ref array);

            Console.WriteLine($" Your array with {array.Length} elements: ");
            DisplayArray(in array);

            Console.WriteLine("\n Your array after using bubble-sort algorithm: ");
            BubbleSort(ref array);
            DisplayArray(in array);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
                array[i] = random.Next(-10, 10);
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.Write($" {array[i]} ");
        }

        static void BubbleSort(ref Int32[] array)
        {
            Int32 temp = 0;

            for (Int32 i = 0; i < array.Length; i++)
            {
                for (Int32 j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

