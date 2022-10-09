using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_18
{

    /*
    Задание №18:
    Найти произведение всех элементов массива целых чисел, меньших 0. Размерность массива – 10. Заполнение массива осуществить с клавиатуры. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[10];

            UInt32 counter = 0;
            Int32 productNumbr = 1;

            FillArray(ref array);

            Console.WriteLine("\n Your array: ");
            DisplayArray(in array, ref counter);

            FindProduct(in array, ref productNumbr);
            Console.WriteLine("Result: {0}", productNumbr);
        }

        static void FillArray(ref Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" Please enter {0} element", i + 1);
                array[i] = Int32.Parse(Console.ReadLine());
            }
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void FindProduct(in Int32[] array, ref Int32 productNumbr)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    productNumbr *= array[i];
            }
        }
    }
}
