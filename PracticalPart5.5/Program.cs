using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            */
            Console.WriteLine("Введите число N");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int[,] vs = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    vs[i, j] = 0;
                }                
            }
            for (int i = 0; i < a; i+=2)
            {
                for (int j = 0; j < b; j+=2)
                {
                    vs[i, j] = 1;
                }
            }
            for (int i = 1; i < a; i+=2)
            {
                for (int j = 1; j < b; j+=2)
                {
                    vs[i, j] = 1;
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0,4}", vs[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
