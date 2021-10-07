﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n/2; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (array[i]>array[j])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            for (int i = n/2; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,4}", array[i]);
            }
            Console.ReadKey();
        }
    }
}
