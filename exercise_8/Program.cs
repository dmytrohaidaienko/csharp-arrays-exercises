using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_8
{
    /*
    Задание №8:
    С 8 до 20 часов температура воздуха измерялась ежечасно. Известно, что в течение этого времени температура понижалась. 
    Определите, в котором часу была впервые отмечена отрицательная температура.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[12];
            UInt32 counter = 0;
            Int32 temperature = 0;
            Int32 time = 8;

            FillArray(ref array);
            Console.WriteLine(" Your array of temperature between 8 and 20: ");
            DisplayArray(in array, ref counter);

            FindTemperature(in array, ref temperature, ref time);
            Console.WriteLine(" \n\n The first time then was negative temperature: {0} \n\n It was at {1} oclock.", temperature, time);
        }

        static void FillArray(ref Int32[] array)
        {
            Random random = new Random();

            for (Int32 i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 10);
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

        static void FindTemperature(in Int32[] array, ref Int32 temperature, ref Int32 time)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    temperature = array[i];
                    time += Array.IndexOf(array, array[i]);
                    return;
                }
            }
        }
    }
}
