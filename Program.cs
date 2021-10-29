using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void randomizer(int[,] number, int n, int m) //заполнение рандомными числами 
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    number[i, k] = rnd.Next(0, 10);
                }
            }
        }


        static void vivod(int[,] number, int n, int m) // вывод матрицы 
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write(number[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        static void Umnoj(int[,] matrica, int[,] matrica2, int[,] matrica3, int n1, int n2, int m1, int m2) // умножение матриц
        {
           
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        matrica3[i, j] = 0;                       
                        for (int k = 0; k < m1; k++)
                        {
                            matrica3[i, j] += matrica[i, k] * matrica2[i, j];
                        }
                        Console.Write(matrica3[i, j] + " ");
                    }
                    Console.WriteLine();
                }
         
        }


        static void Main(string[] args)
        {
            Console.Write("количество строк матрицы 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("количество столбцов матрицы 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("количество строк матрицы 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("количество столбцов матрицы 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            int[,] matrica = new int[n1, m1];
            int[,] matrica2 = new int[n2, m2];
            int[,] matrica3 = new int[n1, m2];
            randomizer(matrica, n1, m1);
            Console.WriteLine("Матрица 1");
            vivod(matrica, n1, m1);
            randomizer(matrica2, n2, m2);
            Console.WriteLine("Матрица 2");
            vivod(matrica2, n2, m2);
            Console.WriteLine("Переумножение матриц 1 и 2");
            if (n2 == m1)
            {
                Umnoj(matrica, matrica2, matrica3, n1, m1, n2, m2);
            }
            else
            {
                Console.WriteLine("количество столбцов не равно количеству строк");
            }
        }
    }
}