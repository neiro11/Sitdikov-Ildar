using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {

        static void Randomizer(int[,] matrica, int n, int m)  // заполенеие массива рандомными числами 
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    matrica[i, k] = rnd.Next(0, 10);
                }
            }
        }


        static void vivod(int[,] matrica1, int n, int m) //вывод матрицы
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write(matrica1[i, k] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }




        static void Umnoj(int[,] matrica, int[,] matrica1, int[,] matrica2, int n1, int n2, int m1, int m2) // перумножениe матриц
        {
            if (n2 == m1)
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int k = 0; k < m2; k++)
                    {
                        matrica2[i, k] = 0;
                        for (int a = 0; a < m1; a++)
                        {
                            matrica2[i, k] += matrica[i, a] * matrica1[a, k];
                        }
                        Console.Write(matrica2[i, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("столбец матрицы 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("строка матрицы 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("столбец матрицы 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("строка матрицы 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            int[,] number = new int[n1, m1];
            int[,] number1 = new int[n2, m2];
            Randomizer(number, n1, m1);
            Console.WriteLine("матрица 1");
            vivod(number, n1, m1);
            Randomizer(number1, n2, m2);
            Console.WriteLine("матртца 2");
            vivod(number1, n2, m2);
            Console.WriteLine("Умножение матриц");
            int[,] number2 = new int[n1, m2];
            Umnoj(number, number1, number2, n1, m1, n2, m2);
        }
    }
}