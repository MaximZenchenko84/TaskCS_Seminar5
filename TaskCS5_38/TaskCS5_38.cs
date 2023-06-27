// Урок 5. Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива

using System;

namespace TaskCS5_38
{
    class TaskCS5_38
    {
        // функция нахождения максимума
        static double max_(double[] array, int num_elem)
        {
            double max = array[0];
            for (int i = 1; i < num_elem; i++)
            {
                max = (array[i] > max) ? array[i] : max;
            }
            return max;
        }

        // функция нахождения минимума
        static double min_(double[] array, int num_elem)
        {
            double min = array[0];
            for (int i = 1; i < num_elem; i++)
            {
                min = (array[i] < min) ? array[i] : min;
            }
            return min;
        }
        static void Main(string[] args)
        {
            double[] array = new double[10000]; // объявление массива 
            Random rnd = new Random();
            Console.WriteLine("Введите количество элементов массива, состоящего из вещественных чисел");
            int num_elements = int.Parse(Console.ReadLine());

            for (int i = 0; i < num_elements; i++)
            {
                Console.Write("Введите " + i + "-й элемент массива ");
                array[i] = double.Parse(Console.ReadLine());
                //array[i] = rnd.Next();
            }
            Console.Write("Введенный массив: [ ");
            for (int i = 0; i < num_elements - 1; i++)
            {
                Console.Write(array[i]); Console.Write(", ");
            }
            Console.Write(array[num_elements - 1]); Console.WriteLine(" ]");

            Console.Write("Максимум равен " + max_(array, num_elements) + "\n");
            Console.Write("Минимум равен " + min_(array, num_elements) + "\n");
            Console.Write("Разница между максимумом и минимумом равна " + (max_(array, num_elements) - min_(array, num_elements)) + "\n");
        }
    }
}
