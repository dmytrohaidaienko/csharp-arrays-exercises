using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_6
{
    /*
    Задание №6:
    Создайте массив А[1..12] с помощью генератора случайных чисел с элементами от –20 до 10 и выведите его на экран. Замените все отрицательные элементы массива числом 0
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[12];

            FillArray(ref array);

            Console.WriteLine("\n Your array: ");
            DisplayArray(in array);

            Console.WriteLine("\n New array: ");
            ReplaceElements(ref array);
            DisplayArray(in array);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
                array[i] = random.Next(-20, 10);
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.Write($" {array[i]} ");
        }

        static void ReplaceElements(ref Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    array[i] = 0;
            }
        }
    }
}
