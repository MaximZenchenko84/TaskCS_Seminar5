// Урок 5. Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях

using System;

namespace TaskCS5_36
{
    class TaskCS5_36
    {
        static void Main(string[] args)
        {
            int[] array_new = new int[10000];
            Random rnd = new Random();

            Console.WriteLine("Введите количество элементов массива, заполненного ");
            Console.WriteLine("случайными числами, не более 10000 ");
            int num_elements = int.Parse(Console.ReadLine()); // количество элементов массива
            int sum_elements_odd_pos = 0; // сумма элементов, стоящих на нечётных позициях
            Console.Write("Массив = [  ");

            // цикл генерации массива и подсчета количества чётных элементов в этом массиве
            for (int i = 0; i < num_elements; i++)
            {
                array_new[i] = rnd.Next();
                Console.Write(array_new[i] + "  ");
            }

            // цикл накопления суммы элементов, стоящих на нечётных позициях
            for (int i = 1; i < num_elements; i=i+2)
            {
                sum_elements_odd_pos += array_new[i];
            }

            Console.WriteLine("]");
            Console.WriteLine("Сумма элементов, стоящих на нечётных позициях " + sum_elements_odd_pos);
        }
    }
}
