using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество нечетных положительных элементов, стоящих на четных местах.
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4}", array[i]);
            }
            int a = 0;
            for (int i = 1; i < n; i=i+2)
            {
                if (array[i]>0)
                {
                    if (array[i]%2!=0)
                    {
                        a++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ответ = {0}",a);
            Console.ReadKey();
        }
    }
}
