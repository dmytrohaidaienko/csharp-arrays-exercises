using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exercise_19
{

    /*
    Задание №19:
    Найти сумму всех элементов массива вещественных чисел, больших заданного числа. Размерность массива – 20. Заполнение массива осуществить случайными числами от 50 до 100. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[20];
            UInt32 counter = 0;
            Int32 sum = 0;

            FillArray(ref array);

            Console.WriteLine("Your array with {0} elements:", array.Length);
            DisplayArray(in array, ref counter);

            Console.Write("Please, enter value: ");
            Int32 value = Int32.Parse(Console.ReadLine());

            FindSum(in array, in value, ref sum);
            Console.WriteLine("The sum of numbers over 20 is {0}", sum);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
                array[i] = random.Next(50, 100);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.WriteLine($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void FindSum(in Int32[] array, in Int32 value, ref Int32 sum)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] > value)
                    sum += array[i];
            }
        }
    }
}
