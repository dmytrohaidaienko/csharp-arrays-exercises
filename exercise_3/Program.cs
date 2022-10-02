using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    /*
    Задание №3: 
    Создайте массив из пяти фамилий и выведите их на экран столбиком, начиная с последней.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            String[] array = new String[5] { "Dmytro", "Denis", "John", "Vanya", "Taras" };

            for (Int32 i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
