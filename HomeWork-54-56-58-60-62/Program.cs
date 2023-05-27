internal partial class Program
{
    public static void Main(string[] args)
    {
        void FillArray(int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                }
            }
            Console.WriteLine();
        }

        string Input(string text)
        {
            Console.Write($"{text} ");
            return Console.ReadLine();
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

        void SelectionSortLow(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                    {
                        if (matrix[i, column] < matrix[i, column + 1])
                        {
                            int temp = matrix[i, column + 1];
                            matrix[i, column + 1] = matrix[i, column];
                            matrix[i, column] = temp;
                        }
                    }
                }
            }
        }

        void MinSumLine(int[,] matrix)
        {
            int minLine = 0;
            int summ = 0;
            int minSumm = 0;  
            for (int j = 0; j < matrix.GetLength(1); j++)            
            { 
                minSumm+=matrix[0,j];
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++) summ += matrix[i,column];                       
                if (summ<minSumm)
                {
                    minSumm = summ;
                    minLine = i;
                }              
            }
            Console.WriteLine($"Наименьшая сумма элементов равна {minSumm} находится в {minLine+1} строке.");
        }

        void MatrixMultiplication(int[,] matrix1, int[,] matrix2, int[,] array)
        {
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                        {
                            sum += matrix1[i, k] * matrix2[k, j];
                        }
                        array[i, j] = sum;
                    }
                }
            }
        }

        void UniqueFillArray(int[,,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = rnd.Next(10, 100);
                    }
                }
            }
        }

        void PrintArrayIndex(int[,,] array)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                    }
                    Console.WriteLine();
                }
            }
        }

        void FillArraySpiral(int[,] array, int n)
        {
            int i = 0;
            int j = 0;
            int num = 10;
            for (int count = 0; count<n*n; count++)
            {
                int c = 0;
                do { array[i, j++] = num++; } while (++c < n - 1);
                for (c = 0; c < n - 1; c++) array[i++, j] = num++;
                for (c = 0; c < n - 1; c++) array[i, j--] = num++;
                for (c = 0; c < n - 1; c++) array[i--, j] = num++;
                ++i; ++j;
        // for (i<=j && j<array.GetLength(1)) j++;
        //         for (i<=j && i<array.GetLength(0)) i++;
        //         for (i>=j && j<array.GetLength(1)) j--;
        //         for i--;
            }
                    
        
                   
        }


        // Задача 54: Задайте двумерный массив. Напишите программу, 
        // которая упорядочит по убыванию элементы каждой строки двумерного массива.

        void Task54()
        {
            int line = Convert.ToInt32(Input("Введите количество строк: "));
            int column = Convert.ToInt32(Input("Введите количество столбцов: "));
            int[,] table = new int[line, column];
            FillArray(table);
            PrintArray(table);
            Console.WriteLine("Сортировка элементов каждой строки по убыванию.");
            SelectionSortLow(table);
            PrintArray(table);
        }
        // Task54();

        // Задача 56: Задайте прямоугольный двумерный массив. 
        // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

        void Task56()
        {
            int line = Convert.ToInt32(Input("Введите количество строк: "));
            int column = Convert.ToInt32(Input("Введите количество столбцов: "));
            int[,] table = new int[line, column];
            FillArray(table);
            PrintArray(table);
            MinSumLine(table);

        }
        // Task56();

        // Задача 58: Задайте две матрицы. Напишите программу, которая будет 
        // находить произведение двух матриц.

        void Task58()
        {
            int line1 = Convert.ToInt32(Input("Введите количество строк для первой матрицы: "));
            int column1 = Convert.ToInt32(Input("Введите количество столбцов для первой матрицы: "));
            int[,] matrix1 = new int[line1, column1];
            int line2 = Convert.ToInt32(Input("Введите количество строк для второй матрицы: "));
            int column2 = Convert.ToInt32(Input("Введите количество столбцов для второй матрицы: "));
            int[,] matrix2 = new int[line2, column2];
            int[,] array = new int[line2, column1];
            FillArray(matrix1);
            FillArray(matrix2);
            Console.WriteLine("Первая матрица: ");
            PrintArray(matrix1);
            Console.WriteLine("Вторая матрица: ");
            PrintArray(matrix2);

            if (column1 == line2)
            {
                MatrixMultiplication(matrix1, matrix2, array);
                Console.WriteLine("Произведение первой и второй матриц: ");
                PrintArray(array);
            }
            else Console.WriteLine("Данные матрицы не могут быть перемножены между собой.");

        }
        // Task58();

        //Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        // Напишите программу, которая будет построчно выводить массив, 
        // добавляя индексы каждого элемента.

        void Task60()
        {
            int x = Convert.ToInt32(Input("Введите количество строк массива: "));
            int y = Convert.ToInt32(Input("Введите количество столбцов массива: "));
            int z = Convert.ToInt32(Input("Введите количество созданных массивов: "));
            int[,,] array = new int[x, y, z];
            UniqueFillArray(array);
            PrintArrayIndex(array);
        }
        // Task60();

        // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

        void Task62()
        {
            int n = 4;
            int[,] array = new int[n, n];
            FillArraySpiral(array,n);
            PrintArray(array);


        }
        // Task62();



    }
}