using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит М чисел, узнать сколько чисел больше нуля

            Console.WriteLine(" Введите общее количество чисел: ");

            int count = int.Parse(Console.ReadLine());

            int[] myArray = new int[count];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите число под номером {i + 1}");

                myArray[i] = int.Parse(Console.ReadLine());
            }

            int GetPositiveDigits(int[] array)
            {
                int result = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        result++;
                    }
                }
                return result;
             }

            int resultPositive = GetPositiveDigits(myArray);

            Console.WriteLine($"В введенном массиве {resultPositive } положительных чисел");

        }
    }
}
