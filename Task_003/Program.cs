// // A(x1;    y1)
// Console.Write("Введите координату точки A по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// // B(x2;    y2)
// Console.Write("Введите координату точки B по оси Х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // AB = √(x2 - x1)^2 + (y2 - y1)^2
// // Math.Sqrt(25) => 5
// // Math.Pow(число, степень) => Math.Pow(4, 2) => 4 возводите во 2 степень = 16
// var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2));
// Console.WriteLine(Math.Round(result,3)); // До целого числа

// // double test = 1.234;
// // // Math.Round(число, количество знаков после запятой) => 1.23
// // Console.WriteLine(Math.Round(test, 2)); // => 1.23
// // A(x1;    y1); B(x2;    y2)
// // A (3,6); B (2,1) -> 5,09 
// // A (7,-5); B (1,-1) -> 7,21


// =============================================================
// Первая задача домашнего задания
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Введённое число не пятизнак. Палиндромность не выяснена.");
}
else
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        Console.WriteLine("Введённое число палиндром.");
    }
    else
    {
        Console.WriteLine("Введённое число НЕ палиндром.");
    }
}
// FIN



// =============================================================
// Вторая задача домашнего задания
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// A(x1;    y1;   z1)
Console.Write("Введите координату точки A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
// B(x2;    y2;    z2)
Console.Write("Введите координату точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());
// AB = √(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2

var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine(Math.Round(result,3)); 
// FIN


// =============================================================
// Третья задача домашнего задания
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    number = number * (-1);
}

for(int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}
Console.WriteLine();
// FIN


// =============================================================
// Доп. задача домашнего задания
// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. На вход будет подаваться число (сумма вклада).
// При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
// Отработав, программа должна вывести общую сумму с начисленными процентами.

Console.Write("Введите сумму вклада: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Доход :");
if (number < 100)
{
    Console.WriteLine(Math.Round(number * 1.05, 2));
}
else if (number >= 100 && number < 200)
{
    Console.WriteLine(Math.Round(number * 1.07, 2));
}
else if (number >= 200)
{
    Console.WriteLine(Math.Round(number * 1.10, 2));
}
// FIN


// =============================================================
// Доп. задача домашнего задания
// Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по величине цифре.
//  Напишите программу, которая определяет интересное число или нет. 
//  Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 4, разница: 9 - 5 = 4.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //Принимаем число с клавиатуры
int max = 0, min = 9, lastDigit = 0, remains = number;


while (remains > 0)
{
    lastDigit = remains % 10;
    remains = remains / 10; // Перебираем цифры, ищем максимальное и минимальное
    
    if (lastDigit > max)
    {
        max = lastDigit;
    }
    if (lastDigit < min)
    {
        min = lastDigit;
    }

//    Console.WriteLine($"Число {number}, последнее число = {lastDigit}, остаток = {remains}.");
}

string str = number.ToString();
int[] numberArray = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    numberArray[i] = int.Parse(str[i].ToString()); // Перевожу исходное число в массив чисел.

}

if (numberArray.Length % 2 == 1) // Если нечётное количесто цифирь - то проверяю интересность
{
    if (max - min == numberArray[numberArray.Length / 2]) // разница мин. и макс == цЫфре из середины числа 
    {
        Console.WriteLine($"Число {number} интересное.");
    }
    else
    {
        Console.WriteLine($"Число {number} неинтересное.");
    }
}
else
{
    Console.WriteLine($"В числе {number} чётное количество цифр => число неинтересное.");
}
Console.WriteLine($"Максимальная цифра {max}, минимальная {min}, разница = {max - min}.");
// Console.WriteLine($"числа {number}, {max}, {min}, {lastDigit}, {remains}.");
// FIN