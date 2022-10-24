using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_23
{

    /*
    Задание №23:
    Переменной t присвоить значение истина, если в одномерном массиве имеется хотя бы одно отрицательное и четное число.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[] { 1, 2, -3, 0, 5 };
            UInt32 counter = 0;
            Boolean t = false;

            Console.WriteLine(" Your array: ");
            DisplayArray(in array, ref counter);

            CheckDigits(in array, ref t);
            Console.WriteLine("\n Are there any numbers below zero in the array: {0}", t);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }

        static void CheckDigits(in Int32[] array, ref Boolean t)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                    t = false;
                else
                {
                    t = true;
                    return;
                }
            }
        }
    }
}
