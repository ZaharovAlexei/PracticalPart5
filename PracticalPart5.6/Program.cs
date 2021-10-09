using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Запросить у пользователя целочисленное значение N.
             Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры.
             Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
             Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.*/

            Console.WriteLine("Введите число N");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы массива размером {0}х{1}",a,a);
            int[,] vs = new int[a, a];
            bool f = true;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    vs[i, j] = Convert.ToInt32(Console.ReadLine());
                }                
            }
            //Контрольная сумма
            int sum_k = 0;
            for (int i = 0; i < a; i++)
            {
                int j = 0;
                sum_k += vs[j, i];
            }
            //Console.WriteLine("Контрольная сумма = {0}",sum_k);
            //проверка суммы по строкам
            //Console.WriteLine("Сумма по строкам");
            for (int i = 0; i < a; i++)
            {
                int sum_a = 0;
                for (int j = 0; j < a; j++)
                {
                    Console.Write("{0,4}", vs[i, j]);
                    sum_a += vs[i, j];
                }
                if (f)
                {
                    if (sum_a == sum_k)
                    {
                        f=true;
                    }
                    else
                    {
                        f = false;
                    }
                }                
                //Console.Write("{0,8}",sum_a);
                Console.WriteLine();
            }
            //Console.WriteLine("Сумма по столбцам");
            //Транспонируем матрицу для проверки суммы столбцов
            for (int i = 0; i < a; i++)
            {
                int sum_b = 0;
                for (int j = 0; j < a; j++)
                {
                    //Console.Write("{0,4}", vs[j, i]);
                    sum_b += vs[j, i];
                }
                if (f)
                {
                    if (sum_b == sum_k)
                    {
                        f = true;
                    }
                    else
                    {
                        f = false;
                    }
                }
                //Console.Write("{0,8}", sum_b);
                //Console.WriteLine();
            }
            //Console.WriteLine("Сумма по 1-ой диагонали");
            //Проверка суммы по 1-ой диагонали
            int sum_dL = 0;
            for (int i = 0; i < a; i++)
            {
                int j = i;
                //Console.Write("{0,4}", vs[i, j]);
                sum_dL += vs[i, j];
            }
            if (f)
            {
                if (sum_dL == sum_k)
                {
                    f = true;
                }
                else
                {
                    f = false;
                }
            }
            //Console.Write("{0,8}", sum_dL);
            //Console.WriteLine();
            //Console.WriteLine("Сумма по 2-ой диагонали");
            //Проверка суммы по 2-ой диагонали
            int sum_dR = 0;
            for (int i = 0; i < a; i++)
            {
                int j = a-1 - i;                
                //Console.Write("{0,4}", vs[i,j]);
                sum_dR += vs[i, j];                
            }
            //Console.Write("{0,8}", sum_dR);
            if (f)
            {
                if (sum_dL == sum_k)
                {
                    f = true;
                }
                else
                {
                    f = false;
                }
            }
            Console.WriteLine("");
            if (f)
            {
                Console.WriteLine("Матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Матрица не является магическим квадратом");
            }
            Console.ReadKey();

        }
    }
}
