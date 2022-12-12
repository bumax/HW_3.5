using System;

namespace ex37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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
            int[] mpArray(int[] array){
                int count = array.Length; // считаем размер исходного массива
                int countNew = (count + 1) / 2; // вычисляем размер нового массива с округдением вверх
                int[]  result = new int[countNew];

                for(int i = 0; i < countNew; i++){
                    if(i != count - i - 1) // проверяем, есть ли пара элементов или мы в середине массива
                        result[i] = array[i] * array[count - i - 1];
                    else
                        result[i] = array[i];
                }
                return result;
            }

            var testArray = getArray(11,0,10);
            printArray(testArray);
            printArray(mpArray(testArray));
        }
    }
}
