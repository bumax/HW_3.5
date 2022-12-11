using System;

namespace ex36
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

            long getOddSumm(int[] array){
                long result = 0;
                if (array.Length > 1)
                    for(int i = 1; i < array.Length; i = i + 2)
                        result += array[i];
                return result;
            }

            var testArray = getArray(10,int.MinValue, int.MaxValue);
            //var testArray = getArray(10,-10, 10); // для теста
            printArray(testArray);
            System.Console.WriteLine($"Сумма нечетных позиций массива равна: {getOddSumm(testArray)}");

        }
    }
}
