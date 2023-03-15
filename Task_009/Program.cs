// // =============================================================
// // Первая задача домашнего задания
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Печатаем все натуральные числа в промежутке от M до N.
/// </summary>
/// <param name="start"> M = start</param>
/// <param name="end"> N = end</param>
/// <returns></returns>
string PrintNumbers(int start, int end)
{
    // Базовый
    if (start == end) return start.ToString();
    // Рекурсивный
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M, N));
// // FIN


// // =============================================================
// // Вторая задача домашнего задания
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Печатаем сумму всех натуральных чисел в промежутке от M до N.
/// </summary>
/// <param name="start"> M = start</param>
/// <param name="end"> N = end</param>
/// <returns></returns>
int PrintNumbers(int start, int end)
{
    // Базовый
    if (start == end) return start;
    // Рекурсивный
    return (start + PrintNumbers(start + 1, end));
}
Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {PrintNumbers(M, N)}");
// // FIN


// // =============================================================
// // Третья задача домашнего задания
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функуция Аккермана A(m,n) для m = {m} и n = {n} равна: {Akkerman(m, n)}");
// // FIN
