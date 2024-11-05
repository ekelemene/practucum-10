using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практикум_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1. В одномерном массиве из 8 целых чисел с явной инициализацией обнулить значения трех элементов, начиная с индекса, равного 1.
            //int[] omas = new int[8]  { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Array.Clear(omas, 1, 3);
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.Write("{0} ", omas[i]);
            //}
            //Console.WriteLine();

            //Задача 2. Изменить размер одномерного массива.
            //int[] omas = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(0, 100);
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Array.Resize(ref omas, 15);
            //foreach (int el in omas)
            //{

            //    Console.WriteLine(el);
            //}

            //Задача 3. Найти индекс первого отрицательного элемента одномерного массива, заполненного случайным образом в диапазоне от -5 до 5.
            //int[] omas = new int[10];
            //Random rnd = new Random(); 
            //for (int i = 0; i < omas.Length; i++) 
            //{
            //    omas[i] = rnd.Next(-5, 5); 
            //}
            //Console.WriteLine("массив:" + string.Join("  ", omas));
            //int firstNegativeIndex = -1;
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    if (omas[i] < 0) 
            //    {
            //        firstNegativeIndex = i;
            //        break; 
            //    }
            //}
            //Console.WriteLine("Индекс первого отрицательного элемента: " + firstNegativeIndex);
            //Console.WriteLine("Первый отрицательный элемент: " + omas[firstNegativeIndex]);
            

        }
    }
}
