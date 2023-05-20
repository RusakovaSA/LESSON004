using System;
internal class Program
{
    static void Main(string[] args)
    {
        void FillArrayDouble(double[,] matrix, int minValue = 0, int maxValue = 10)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(minValue, maxValue) + rnd.NextDouble() / 100;
                }
            }
            Console.WriteLine();
        }

        void PrintArrayDouble(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{Math.Round(matrix[i, j], 4)}  ");
                }
                Console.WriteLine();
            }
        }

        string Input(string text)
        {
            Console.Write($"{text} ");
            return Console.ReadLine();
        }

        void FillArray(int[,] matrix, int minValue = 0, int maxValue = 10)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            Console.WriteLine();
        }

        void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        void FindElement(int[,] matrix, int line, int column)
        {
            bool flag = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (line == i && column == j)
                    {
                        flag = true;
                    }
                }
            }
            if (flag) Console.WriteLine($"Число {matrix[line, column]}, с заданными позициями элемента, присутствует в двумерном массиве");
            else Console.WriteLine("Число, с заданными позициями элемента, не существует");
        }

        double AverageSummNum(int[,] matrix,int num)
        {
            int j = num;
            double summ = 0;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                summ = summ + matrix[i, j];                    
            }
         
            Console.WriteLine($"Сумма чисел в столбце {j} равна {summ}.");
            Console.WriteLine($"Количество чисел в первом столбце {matrix.GetLength(0)}.");    
            return summ/matrix.GetLength(0);
            }
      
        // Задача 47. Задайте двумерный массив размером m×n, 
        // заполненный случайными вещественными числами. m = 3, n = 4.

        void Task47()
        {
            double[,] table = new double[3, 4];
            FillArrayDouble(table);
            PrintArrayDouble(table);
        }
        // Task47();

        // Задача 50. Напишите программу, которая на вход принимает 
        // позиции элемента в двумерном массиве, и возвращает значение этого элемента 
        // или же указание, что такого элемента нет.

        void Task50()
        {
            int[,] table = new int[5, 5];
            FillArray(table);
            PrintArray(table);
            int line = Convert.ToInt32(Input("Введите номер позиции элемента в строке: "));
            int column = Convert.ToInt32(Input("Введите номер позиции элемента в столбце: "));
            FindElement(table, line, column);
        }

        // Task50();

        // Задача 52. Задайте двумерный массив из целых чисел. 
        // Найдите среднее арифметическое элементов в каждом столбце.

        void Task52()
        {
            int[,] table = new int[5, 5];
            FillArray(table);
            PrintArray(table);
            int num = Convert.ToInt32(Input("Введите номер столбца для дальнейшего расчета среднего арифметического: "));
            Console.WriteLine($"Среднее арифметическое элементов в столбце {num} равно {AverageSummNum(table)}.");
        }
        Task52();


    }
}

