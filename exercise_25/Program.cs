using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_25
{

    /*
    Задание №25:
    Написать программу благодаря которой будет возможность добавлять и удалять элементы в массиве в не зависимости от расположения элеметов.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[] { 1, 2, 3, 4, 5 };
            Int32 arrayLength = array.Length;

            Console.WriteLine(" Your array: ");
            DisplayArray(in array);

            Console.WriteLine("\n Please, choose one of the options!");
            Console.WriteLine(" 1. Add element inside array.");
            Console.WriteLine(" 2. Remove element from array.");
            Int32 choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(" Please enter the index of new element: ");
                    Int32 addElement = Int32.Parse(Console.ReadLine());

                    Console.WriteLine(" Enter your element: ");
                    Int32 inputElement = Int32.Parse(Console.ReadLine());

                    AddElement(ref array, in arrayLength, in addElement, in inputElement);

                    Console.WriteLine(" Array after adding new element: ");
                    DisplayArray(in array);
                    break;

                case 2:
                    Console.WriteLine(" Please enter the index for remove element: ");
                    Int32 removeElement = Int32.Parse(Console.ReadLine());

                    RemoveElement(ref array, in arrayLength, in removeElement);

                    Console.WriteLine(" Array after removing {0} element: ", removeElement + 1);
                    DisplayArray(in array);
                    break;
            }
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.Write($" {array[i]} ");
        }

        static void AddElement(ref Int32[] array, in Int32 arrayLength, in Int32 addElement, in Int32 inputElement)
        {
            Int32[] newArray = new Int32[arrayLength + 1];

            for (Int32 i = 0; i < addElement; i++)
                newArray[i] = array[i];

            newArray[addElement] = inputElement;

            for (Int32 i = addElement + 1; i < newArray.Length; i++)
                newArray[i] = array[i - 1];

            array = newArray;
        }

        static void RemoveElement(ref Int32[] array, in Int32 arrayLength, in Int32 removeElement)
        {
            Int32[] newArray = new Int32[arrayLength - 1];

            for (Int32 i = 0; i < removeElement; i++)
                newArray[i] = array[i];

            for (Int32 i = removeElement; i < newArray.Length; i++)
                newArray[i] = array[i + 1];

            array = newArray;
        }
    }
}
