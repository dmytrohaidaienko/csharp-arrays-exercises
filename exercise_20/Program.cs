using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_20
{

    /*
    Задание №20:
    Найти сумму всех элементов массива целых чисел, которые меньше среднего арифметического элементов массива. 
    Размерность массива –20. Заполнение массива осуществить случайными числами от 150 до 300. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[20];
            UInt32 counter = 0;
            Int32 sum = 0;

            FillArray(ref array);

            Console.WriteLine(" Your array: ");
            DisplayArray(in array, ref counter);

            Double arrayAverage = (Double)array.Average();
            Console.WriteLine("\n Average of array is {0}", arrayAverage);

            FindSum(in array, in arrayAverage, ref sum);
            Console.WriteLine(" Sum is {0}", sum);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
                array[i] = random.Next(150, 300);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void FindSum(in Int32[] array, in Double arrayAverage, ref Int32 sum)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] < arrayAverage)
                    sum += array[i];
            }
        }
    }
}
