using System;

namespace HW_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

            int[] getArray(int count = 1, int minVal = 0, int maxVal = 100)
            {
                int[] result = new int[count];
                Random rnd = new Random();
                for(int i = 0; i < count; i++) 
                    result[i] = rnd.Next(minVal, maxVal);
                return result;
            }
            void printArray(int[] array){
                Console.WriteLine("[{0}]", string.Join(", ", array));
            }

            var testArray = getArray(100,0,int.MaxValue);
            var positiveCount = 0;
            foreach (var element in testArray)
            {
                positiveCount += element % 2 == 0 ? 1 : 0;
            }

            printArray(testArray);
            System.Console.WriteLine($"Количество четных чисел в данном массиве: {positiveCount}");
                    }
    }
}
