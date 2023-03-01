// // void: нет оператора return 

// // тип_возр_значения имя (параметры)

// // int Calculate(int a, int b, char sign) // Два числа: a, b; 3 параметр: знак(*; /;)
// // {
// //     int result = 0;
// //     // 'для char-a', "двойные кавычки"
// //     if (sign == '*')
// //     {
// //         result = a * b;
// //     }
// //     else if (sign == '+')
// //     {
// //         result = a + b;
// //     }
// //     else if (sign == '-')
// //     {
// //         result = a - b;
// //     }
// //     else
// //     {
// //         Console.WriteLine("Обработка искл. : такого знака нет");
// //     }
// //     return result;
// // }
// // Console.WriteLine(Calculate(1,2, '+')); // Вызов метода: имя_метода(параметры)
// // Console.WriteLine(Calculate(3,2, '*'));
// // Console.WriteLine(Calculate(100,35, '-'));
// // Console.WriteLine(Calculate(100,35, '_'));


// // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// // 1. Без метода
// // Console.Write("Введите число А: ");
// // // limit - искомое число А
// // int limit = Convert.ToInt32(Console.ReadLine());
// // int sum = 0;
// // for (int i = 1; i <= limit; i++)
// // {
// //     sum += i;   // sum = sum + i;

// // }
// // Console.WriteLine($"Cумма чисел от 1 до {limit} = {sum}");

// // 2. Хардкод
// // Console.Write("Введите число А: ");
// // int limit = Convert.ToInt32(Console.ReadLine());
// // //PascalCase - для методов, то есть, каждое новое слово начинается с большой буквы
// // int GetSum(int A) // A = limit
// // {
// //     int sum = 0;
// //     for (int i = 1; i <= A; i++)
// //     {
// //         sum += i;   // sum = sum + i;
// //     }
// //     return sum;
// // }

// // Console.WriteLine($"Cумма чисел от 1 до {limit} = {GetSum(limit)}");
// // Console.WriteLine($"Cумма чисел от 1 до {3} = {GetSum(3)}");
// // Console.WriteLine($"Cумма чисел от 1 до {4} = {GetSum(4)}");
// // Console.WriteLine($"Cумма чисел от 1 до {4} = {GetSum(4)}");

// // Console.Write("Введите число: ");
// // int num = Convert.ToInt32(Console.ReadLine());

// // int GetCountNumber(int number)
// // {
// //     int count = 0; // Количество цифр в числе
// //     while (number > 0)
// //     {
// //         count++; // count = count + 1
// //         number /= 10; // number = number / 10
// //     }
// //     return count;
// // }
// // // Вызов метода

// // Console.WriteLine($"Количество цифр: {GetCountNumber(num)}");

// // Массив на 8 элементов, состоящий из нулей и единиц
// // Метод заполняет массив, возращает - заполненный массив int[]
// // Размер массива - 8
// // int[] GetBinaryArray(int size)
// // {
// //     int[] array = new int[size]; // Получается массив на size(8) элементов
// //     // Массив состоит из 8 нулей
// //     // size = array.Length
// //     for (int i = 0; i < size; i++)
// //     {
// //         // array[i] = new Random().Next(0,2);
// //         array[i] = new Random().Next(2); // [0;1]
// //         // array[0] = 0, array[1] = 0, array[2] = 0
// //     }
// //     return array;
// // }
// // int[] resultArray = GetBinaryArray(8);
// // double[] test = new double[10]; 
// // // for (int i = 0; i < resultArray.Length; i++)
// // // {
// // //     Console.Write(resultArray[i] + "\t"); 
// // // }
// // Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");


// // // =============================================================
// // // Первая задача домашнего задания
// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// System.Console.Clear();
// Console.Write("Введите число А (основание степени): ");
// decimal basis = Convert.ToDecimal(Console.ReadLine());
// Console.Write("Введите число B (показатель степени): ");
// int degree = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// //Натуральные числа - положительные, целые с 1 до упавшей на бок 8
// decimal Exponentiation(decimal A, int B) // A = basis, B = degree
// {
//     decimal result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         result *= A;   // sum = sum + i;
//     }
//     return result;
// }

// Console.WriteLine($"{basis} в степени {degree} = {Exponentiation (basis, degree)}");
// // // FIN



// // // =============================================================
// // // Вторая задача домашнего задания
// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// int SumOfDigits(int B) // B = number
// {
//     int result = 0;
//     while (B > 0)
//     {
//         result += B % 10; //Последняя цифра в результат
//         B /= 10;   // Отсекаем от исходного числа последнюю цифру
//     }
//     return result;
// }

// System.Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {number} = {SumOfDigits(number)}");
// // // FIN

// // // =============================================================
// // // Третья задача домашнего задания
// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// int[] GetArray(int size)
// {
//     int[] array = new int[size]; // Получается массив на size(8) элементов
//     // Массив состоит из 8 нулей
//     // size = array.Length
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100); // [0;99]
       
//     }
//     return array;
// }

// int[] resultArray = GetArray(8);
 
// System.Console.Clear();
// Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
// // // FIN


// //микрофон есть, секйчас пытаюсь настроить

// System.Console.Clear();
// Console.Write("Введите длину первой стороны треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите длину первой стороны треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите длину первой стороны треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a + b > c && b + c > a && a + c > b)
// {
//     Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
// }
// else
// {
//     Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует");
// }


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// System.Console.Clear();
// Console.Write("Введите порядковый номер числа Фибоначчи: ");
// int fib_number = Convert.ToInt32(Console.ReadLine());
//  int a = 0, b = 1, c = 0;


// if (fib_number < 2)
// {
//     Console.WriteLine("1    1");
// }
// Console.Write(a + " " + b);

//  for (int i = 2; i < fib_number; i++)  
//     {  
//         c= a + b;  
//         Console.Write(" {0} ", c);  
//         a= b;  
//         b= c;  
//     }  


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// System.Console.Clear();
// Console.Write("Введите десятичное число для преобразования: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = 0; // a - остаток после % деления из которого формируется число в 
// //    двоичной системе исчисления
// int i = 0;
 
//         int[] b = new int[10]; // массив с помощью которого двоичное число позже 
//                                  //будет выведено с конца для правильного отображения 
 
//         while (number >= 1)
//         {
//             a = number % 2;
//             b[i] = a;
//             i++;
 
//             number = number / 2;
 
//            // Console.Write(a);
//         };
 
//        // Console.WriteLine();
 
//         for (i = (b.Length - 1); i >= 0; i--)
//         {
//             // if (b[i] == 0)
//             // {

//             // }
//             Console.Write(b[i]);
//         }
//         Console.WriteLine();