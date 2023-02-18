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

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 10000 || number > 99999)
// {
//     Console.WriteLine("Введённое число не пятизнак. Палиндромность не выяснена.");
// }
// else
// {
//     if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
//     {
//         Console.WriteLine("Введённое число палиндром.");
//     }
//     else
//     {
//         Console.WriteLine("Введённое число НЕ палиндром.");
//     }
// }
// // FIN



// =============================================================
// Вторая задача домашнего задания
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// // A(x1;    y1;   z1)
// Console.Write("Введите координату точки A по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  A по оси Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// // B(x2;    y2;    z2)
// Console.Write("Введите координату точки B по оси Х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки  B по оси Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// // AB = √(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2

// var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
// Console.WriteLine(Math.Round(result,3)); 
// // FIN


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