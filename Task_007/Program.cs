// =============================================================
// Первая задача домашнего задания
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

float[,] GetMatrix(int rows, int cols)
{
    float[,] matrix = new float[rows, cols];
    Random rand = new Random();
    var array = new byte[4];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            rand.NextBytes(array);
            matrix[i,j] = BitConverter.ToSingle(array, 0);
        }
    }
    return matrix;
}

void PrintMatrix(float[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
float[,] resultMatrix = GetMatrix(rows, columns);
PrintMatrix(resultMatrix);
// FIN

// =============================================================
// Вторая задача домашнего задания
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];   
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = new Random().Next(0,100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, columns);
Console.Clear();
Console.WriteLine("В матрице: ");
PrintMatrix(resultMatrix);
Console.Write("Выберите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("и столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
if (row >= 0 && row <= rows && column >= 0 && column <= columns)
{
    Console.WriteLine($"В {row} строке и {column} столбце находится {resultMatrix[row - 1, column - 1]}");
}
else
{
    Console.WriteLine($"Элемент в {row} строке и {column} столбце не существует");
}

// FIN

// =============================================================
// Третья задача домашнего задания
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];   
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = new Random().Next(0,100);
        }
    }
    return matrix;
}

void ArithmeticMean(int[,] matr)
{
    float[] arithmetic_mean = new float[matr.GetLength(1)];
    float sum_maxtrix_col = 0;

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum_maxtrix_col += matr[j,i];
        }
        arithmetic_mean[i] = sum_maxtrix_col / matr.GetLength(0);
        sum_maxtrix_col = 0;
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        Console.Write(arithmetic_mean[i] + "\t");
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, columns);
Console.Clear();
Console.WriteLine("В матрице: ");
PrintMatrix(resultMatrix);
ArithmeticMean(resultMatrix);
// FIN