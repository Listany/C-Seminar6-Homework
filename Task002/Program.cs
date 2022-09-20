using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // найти точку пересечения двух прямых, заданных уравнениями y = k1*x + b1, y = k2*x + b2
            // k1, k2, b1, b2 - задаются пользователем

            double [] GetCrossingPoint (double k1method, double k2method, double b1method, double b2method)
            {
                double[] result = new double[2];


                result[0] = (b2method - b1method) / (k1method - k2method);

                result[1] = (k1method * ((b2method - b1method) / (k1method - k2method))) + b1method;

                return result;
            }

            Console.WriteLine("Введите значение k1"); // ввод коэффициентов

            double k1 = 0;
            double k2 = 0;
            double b1 = 0;
            double b2 = 0;


            try
            {
                k1 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }


            Console.WriteLine("Введите значение k2"); 

            try
            {
                k2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }

           
            Console.WriteLine("Введите значение b1");

            try
            {
                b1 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }


            Console.WriteLine("Введите значение b2");

            try
            {
                b2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }


            double[] resultCrossing = GetCrossingPoint(k1, k2, b1, b2);

            Console.WriteLine("Координаты точки пересечения равны: ");

            for (int i = 0; i < resultCrossing.Length; i++)
            {
                Console.WriteLine(resultCrossing[i]);
            }
        }
    }
}
