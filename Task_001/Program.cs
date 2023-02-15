//===================================================
// Console.WriteLine("Hello, World!");
// Console.Write("Введите число, для которого мы ищем квадрат: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number * number;
// Console.WriteLine("Квадрат от числа: " + number + " равен " + result);
//======================================================

// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());
// if (firstValue == Math.Pow(secondValue, 2))
// {
//     Console.WriteLine("Число " + firstValue + " является квадратом от " + secondValue);
// }
// else
// {
//     Console.WriteLine("Число " + firstValue + " НЕ является квадратом от " + secondValue);
// }
//=============================================================
// Напишите программу, которая выводит все целые числа от -N до N
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 0)
// {
//     Console.WriteLine("Введено отрицательное число, умножили его на -1 :");
//     N = N * (-1);
// }

// int negativeN = N * (-1);
// while (negativeN <= N)
// {
//     Console.Write(negativeN + "  ");
//     negativeN++;
// }
// Console.WriteLine();

// =============================================================
// Первая задача домашнего задания
// На входе два числа. На выходе - какое больше, какое меньше.


// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue == secondValue)
// {
//     Console.WriteLine(secondValue + " равно " + firstValue);
// }

// else 
// {
//     if (firstValue > secondValue)
//     {
//         Console.WriteLine(firstValue + " больше " + secondValue);
//     }
//     else
//     {
//         Console.WriteLine(secondValue + " больше " + firstValue);
//     }
// }
// // FIN


// =============================================================
// Вторая задача домашнего задания
// На входе три числа. На выходе - максимальное. - я бы запитонил ввод в список и вывел максимум встроенной функцией:
// // numbers = list(map(int, input("Введите числа через пробел: ").split()))
// // print(max(numbers))
// // или в одну строку вообще 
// // print(max(list(map(int, input("Введите числа через пробел: ").split()))))

// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int thirdValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue > secondValue && firstValue > thirdValue)
// {
//     Console.WriteLine("Максимальное из введённых чисел: " + firstValue);
// }
// else
// {
//     if (secondValue > thirdValue && secondValue > firstValue)
//     {
//         Console.WriteLine("Максимальное из введённых чисел: " + secondValue);
//     }
//     else
//     {
//         Console.WriteLine("Максимальное из введённых чисел: " + thirdValue);
//     }
// }
// // FIN

// =============================================================
// Третья задача домашнего задания
// На входе число. На выходе - odd or even message

// Console.Write("Введите число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());

// if (firstValue % 2 == 0)
// {
//     Console.WriteLine(firstValue + " - чётное число");
// }
// else
// {
//     Console.WriteLine(firstValue + " - нечётное число");
// }
// // FIN


// =============================================================
// Четвёртая задача домашнего задания
// На входе число. На выходе - even numbers from 1 to N

// Console.Write("Введите число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());
// int number = 0;

// if (firstValue < 0)
// {
//     while (number >= firstValue)
//     {
//         Console.Write(number + " ");
//         number -=2;
//     }  
// }
// else
// {
//     while (number <= firstValue)
//     {
//         Console.Write(number + " ");
//         number +=2;
//     }  
// }
// Console.WriteLine();
// //FIN
