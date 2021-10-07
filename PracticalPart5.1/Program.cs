using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
            const int n = 7;
            int[] array = new int[n];
            float sum=0;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое равно = {0}",sum/n);
            Console.ReadKey();
        }
    }

}

