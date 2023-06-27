// Урок 5. Задача 34. Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

namespace TaskCS5_34
{
    class TaskCS5_34
    {
        /*static int fill_array(int[] input_array)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите количество элементов массива\n");
            Console.WriteLine("заполненного случайными положительными трехзначными числами ");
            int num_elements = int.Parse(Console.ReadLine());
            Console.WriteLine("Массив = [");
            for (int i = 0; i <= num_elements; i++)
            {
                input_array[i] = rnd.Next(100, 999);
                Console.Write(", " + input_array[i]);
            }
            Console.WriteLine("]");
            return 0;
        }*/
        static void Main(string[] args)
        {
            int[] array_new = new int[10000];
            Random rnd = new Random();

            Console.WriteLine("Введите количество элементов массива, заполненного ");
            Console.WriteLine("случайными положительными трехзначными числами, не более 10000 ");
            int num_elements = int.Parse(Console.ReadLine()); // количество элементов массива
            int num_even = 0; // количество чётных элементов в массиве
            Console.Write("Массив = [  ");

            // цикл генерации массива и подсчета количества чётных элементов в этом массиве
            for (int i = 0; i < num_elements; i++)
            {
                array_new[i] = rnd.Next(100, 999);
                Console.Write(array_new[i]+"  ");
                num_even = ((array_new[i] % 2) == 0) ? (num_even+1) : (num_even);
            }

            Console.WriteLine("]");
            Console.WriteLine("Количество чётных элементов массива равно " + num_even);
        }
    }
}
