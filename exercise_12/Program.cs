using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_12
{

    /*
    Задание №12:
    Создайте массив из 15 целочисленных элементов и определите среди них минимальное значение. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[15] { 12, 1, 6, 2, 48, 3, 18, 11, 33, 54, 62, 91, 15, 6, 4 };
            UInt32 counter = 0;

            Console.WriteLine(" Your array: ");
            DisplayArray(in array, ref counter);

            Int32 minElement = array.Min();

            Console.WriteLine("\n The lowest value in the array: {0}", minElement);
        }

        static void DisplayArray(in Int32[] array, ref UInt32 counter)
        {
            if (counter >= array.Length)
                return;

            Console.Write($" {array[counter]} ");
            counter++;

            DisplayArray(in array, ref counter);
        }
    }
}
