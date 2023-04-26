using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

            Console.Write("Укажите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] showArr = CreateArr(size);
            ShowArray(showArr);
            Console.WriteLine(PositivNum(showArr));
            Console.ReadKey();
        }

        static int PositivNum(int[] array)
        {
            int numbers = 0;
            for (int j = 0; j < array.Length; j++)
                if (array[j] % 2 == 0)
                    numbers++;
            return numbers;
        }
        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        static int[] CreateArr(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = new Random().Next(100, 1000);
            return array;
        }
    }
}
