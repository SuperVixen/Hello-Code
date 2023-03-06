// =============================================================
// Первая задача домашнего задания
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputArray (int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество элементов: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Кол-во элементов больше 0 - {CountNumbers(array)}");
// FIN

// =============================================================
// Вторая задача домашнего задания
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Для y = k1 * x + b1 введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для y = k1 * x + b1 введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для y = k2 * x + b2 введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для y = k2 * x + b2 введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double x = (b1 - b2) / (k2 - k1);
double y = k2 * x + b2;

if (k1 == k2)
{
    Console.WriteLine($"Графики y = {k1} * x + {b1} и y = {k2} * x + {b2} не пересекаются.");
}
else
{
    Console.WriteLine($"Графики y = {k1} * x + {b1} и y = {k2} * x + {b2} пересекаются в точке ({x}, {y}).");
}
// FIN

// // =============================================================
// // Доп. задача домашнего задания
// Задача 42 (необязательно): Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InputN()
{
    int NumberToInput = 0;
    Console.Write($"Введите число: ");
    NumberToInput = Convert.ToInt32(Console.ReadLine());
    return NumberToInput;
}
void PrintArray(int[] ArrayToPrint)
{    
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{ArrayToPrint[i]}");
    }
    Console.WriteLine();
}

int[] DecToBinConvert(int decNumberToConvert)
{
    int temp = decNumberToConvert;
    int binArraySize = 0;
    for (binArraySize = 0; temp > 0; binArraySize++)
        temp = temp / 2;
    int[] binArray = new int[binArraySize];
    for (int i = binArraySize - 1; i >= 0; i--)
    {
        binArray[i] = decNumberToConvert % 2;
        decNumberToConvert = decNumberToConvert / 2;
    }
    return binArray;
}



int decNumber = InputN();
int[] binNumberArray = DecToBinConvert(decNumber);

Console.WriteLine("Число {0} в двоичной системе:", decNumber);
PrintArray(binNumberArray);

// // FIN