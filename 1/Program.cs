// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void ListNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
    }
    if (m < n)
    {
        ListNumbers(m, n - 1);
        Console.Write($",{n} ");
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        ListNumbers(m - 1, n);

    }
}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {m}, n = {n} - > \"");
ListNumbers(m, n);
Console.WriteLine("\"");













