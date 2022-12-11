using System;

namespace ex38
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            double[] testArray = {2.718, 1.442, 0.434, 0.693, 2.302, 3.141, 1.57, 0.785, 0.318, 0.636, 1.128, 1.414, 0.707};
            /*
            // Самый быстрый способ:
            Array.Sort(testArray);
            System.Console.WriteLine("Разнича между максимальным и минимальным значениями: {0}", testArray[testArray.Length - 1] - testArray[0]);
            */
            double getDiff(double[] array){
                double maxVal = array[0];
                double minVal = array[0];
                foreach(var element in array){
                    maxVal = maxVal < element ? element : maxVal;
                    minVal = minVal > element ? element : minVal;
                }
                return maxVal - minVal;
            }

            System.Console.WriteLine("Разнича между максимальным и минимальным значениями: {0}", getDiff(testArray));
        }
    }
}
