// // =============================================================
// // Первая задача домашнего задания
// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

System.Console.Clear();
int[] GetArray(int size)
{
    int[] array = new int[size]; // Получается массив на size элементов

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000); // трехзначные числа
       
    }
    return array;
}

int EvenNumbered(int[] our_array)
{
    int even_number = 0;
    for (int i = 0; i < our_array.Length; i++)
    {
        if (our_array[i] % 2 == 0)
        {
            even_number++;
        }
    }
    return even_number;
}

Console.Write("Введите количество элементов массива: ");
int array_len = Convert.ToInt32(Console.ReadLine());
int[] resultArray = GetArray(array_len);
 
Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
Console.WriteLine($"Чётных элементов --> {EvenNumbered(resultArray)}");
// // FIN


// // =============================================================
// // Вторая задача домашнего задания
// // Задача 36: Задайте одномерный массив, заполненный случайными числами.
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

System.Console.Clear();
int[] GetArray(int size)
{
    int[] array = new int[size]; // Получается массив на size элементов

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100); // трехзначные числа
    }
    return array;
}

int EvenSum(int[] our_array)
{
    int even_sum = 0;
    for (int i = 1; i < our_array.Length; i += 2)
    {
        even_sum += our_array[i];
    }
    return even_sum;
}

Console.Write("Введите количество элементов массива: ");
int array_len = Convert.ToInt32(Console.ReadLine());
int[] resultArray = GetArray(array_len);

Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
Console.WriteLine($"Сумма нечётных элементов --> {EvenSum(resultArray)}");
// // FIN


// // =============================================================
// // Третья задача домашнего задания
// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76
// // Используйте NextDouble().

System.Console.Clear();
double[] GetArray(int size)
{
    double[] array = new double[size]; // Получается массив на size элементов

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble(); // трехзначные числа
    }
    return array;
}

double MaxArray(double[] our_array)
{
    double max_number = 0;
    for (int i = 0; i < our_array.Length; i++)
    {
        if (our_array[i] > max_number)
        {
            max_number = our_array[i];
        }
    }
    return max_number;
}

double MinArray(double[] our_array)
{
    double min_number = 1;
    for (int i = 0; i < our_array.Length; i++)
    {
        if (our_array[i] < min_number)
        {
            min_number = our_array[i];
        }
    }
    return min_number;
}

Console.Write("Введите количество элементов массива: ");
int array_len = Convert.ToInt32(Console.ReadLine());
double[] resultArray = GetArray(array_len);

Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
// Console.WriteLine($"Максимальный элемент: {MaxArray(resultArray)}");
// Console.WriteLine($"Минимальный элемент: {MinArray(resultArray)}");
Console.WriteLine($"Разница максимального и минимального элементов --> {MaxArray(resultArray) - MinArray(resultArray)}");

// // FIN


// // =============================================================
// // Доп. задача домашнего задания
// Доп. задачка:
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

System.Console.Clear();
int[] GetArray(int size)
{
    int[] array = new int[size]; // Получается массив на size элементов

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

int[] EvenMultiplyArrayNumberz(int[] our_array)
{
    int[] array = new int[(our_array.Length / 2)]; // Получается массив на size элементов

    for (int i = 0; i < (our_array.Length) / 2; i++)
    {
        array[i] = our_array[i] * our_array[our_array.Length - i - 1];
    }
    return array;
}

int[] OddMultiplyArrayNumberz(int[] our_array)
{
    int[] array = new int[(our_array.Length / 2) + 1]; // Получается массив на size элементов

    for (int i = 0; i < (our_array.Length) / 2 + 1; i++)
    {
        if (i < (our_array.Length) / 2)
        {
            array[i] = our_array[i] * our_array[our_array.Length - i - 1];
        }
        else
        {
            array[i] = our_array[i];
        }
    
    }
    return array;
}
Console.Write("Введите количество элементов массива: ");
int array_len = Convert.ToInt32(Console.ReadLine());
int[] resultArray = GetArray(array_len);

Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
// Console.WriteLine($"Массив произведений: [ {MultiplyArrayNumberz(resultArray)} ]");
if (array_len % 2 == 0)
{
    Console.WriteLine($"Массив произведений: [ {String.Join(", ", EvenMultiplyArrayNumberz(resultArray))} ]");
}
else
{
    Console.WriteLine($"Массив произведений: [ {String.Join(", ", OddMultiplyArrayNumberz(resultArray))} ]");
}

// // FIN