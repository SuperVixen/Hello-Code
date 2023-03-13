// // =============================================================
// // Первая задача домашнего задания
// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];   
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = new Random().Next(minValue, maxValue);
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

void PrintSorted(int[] array)
{
    Array.Sort(array);
    Array.Reverse(array);
    string result = string.Join("\t", array);
    Console.WriteLine(result);
}

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
int[] arrayToSort = new int[columns];
Console.Clear();
Console.WriteLine("Исходная матрица: ");
PrintMatrix(resultMatrix);
Console.WriteLine("Строки по убыванию: ");
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        arrayToSort[j] = resultMatrix[i,j];
    }
    PrintSorted(arrayToSort);
}
// // FIN

// // =============================================================
// // Вторая задача домашнего задания
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];   
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = new Random().Next(minValue, maxValue);
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

int minStringOfArray(int[,] array)
{
    int[] sumOfRow = new int[array.GetLength(0)];
    Console.WriteLine("Суммы строк: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfRow[i] += array[i,j];
        }
        Console.WriteLine(sumOfRow[i]);
    }

    int min = 11000; 
    int index = 0;
    for (int i = 0; i < sumOfRow.Length; i++)
    {
        if (sumOfRow[i] < min)
        {
            min = sumOfRow[i];
            index = i;  
        }
    }
    return index + 1;
}

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
// int[] arrayToSort = new int[columns];
Console.Clear();

Console.WriteLine("Исходная матрица: ");
PrintMatrix(resultMatrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minStringOfArray(resultMatrix)} строка.");
// // FIN

// // =============================================================
// // Третья задача домашнего задания
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];   
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = new Random().Next(minValue, maxValue);
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

/// <summary>
/// Этот метод перемножает матрицы
/// Умножение матрицы А на матрицу В имеет смысл в том случае, когда число
/// столбцов матрицы А совпадает с числом строк в матрице В.
/// В результате умножения двух прямоугольных матриц получается матрица,
/// содержащая столько строк, сколько строк было в первой матрице и столько 
/// столбцов, сколько столбцов было во второй матрице.
/// </summary>
/// <param name="matr1">Первая матрица</param>
/// <param name="matr2">Вторая матрица</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
int[,] MultiplyMatrix(int[,] matr1, int[,] matr2)
{
    int [,] multiplyResult = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        Console.WriteLine("Умножение матриц невозможно.");
        // return;
    }
    else
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                multiplyResult[i,j] = 0;
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    multiplyResult[i,j] += matr1[i,k] * matr2[k,j];
                }
            }
        }
    }
    return multiplyResult;
}

Console.Write("Введите количество строк 1-ой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-ой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix1 = GetMatrix(rows1, columns1, 2, 6);

Console.Write("Введите количество строк 2-ой матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-ой матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix2 = GetMatrix(rows2, columns2, 2, 5);

Console.WriteLine("Исходные матрицы: ");
PrintMatrix(resultMatrix1);
Console.WriteLine();
PrintMatrix(resultMatrix2);
Console.WriteLine("Произведение матриц: ");
PrintMatrix(MultiplyMatrix(resultMatrix1, resultMatrix2));
// // FIN

// // =============================================================
// // Четвертая задача домашнего задания
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetMatrix(int rows, int cols, int thirdDimention, int minValue, int maxValue)
{
    int[,,] matrix = new int[rows, cols, thirdDimention];   
    int value = new Random().Next(10, 50);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < thirdDimention; k++)
            {
                matrix[i,j,k] += value;
                value += new Random().Next(minValue, maxValue);       
            }           
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i,j,k]}({i},{j},{k})" + "\t");
            }
            Console.WriteLine();
        }        
    }
}

int[,,] resultMatrix = GetMatrix(2, 2, 2, 3, 6);
Console.Clear();
PrintMatrix(resultMatrix);
// // FIN

// ================================================================
// ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Spiral(int squareDimention)
{
    int[,] matrix = new int[squareDimention, squareDimention];
    int value = 1;
    int i = 0; 
    int j = 0;

    while (value <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        {
            j++;
        }    
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
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

PrintMatrix(Spiral(4));