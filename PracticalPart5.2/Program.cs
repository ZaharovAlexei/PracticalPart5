using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива
            int[] array = new int[15];
            Random random = new Random();            
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine();
            int min = array[0];
            int max = array[0];
            foreach(int a in array)
            {
                if (a > max)
                    max = a;
            }
            foreach(int a in array)
            {
                if (a < min)
                    min = a;
            }
            Console.WriteLine("Сумма максимального и минимального значения = {0}",max+min);
            Console.ReadKey();
        }
    }
}
