// Напишите программу вычисления функции Аккермана с помощью рекуссии. Даны два неотрицательных числа m и n.
// Пример
// m =2, n = 3 -> A(m,n) = 29


int AckFunc(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AckFunc(n - 1, 1);
    }
    else
    {
        return AckFunc(n - 1, AckFunc(n, m - 1));
    }
}

Console.WriteLine("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write($"m = {M}, n = {N} -> AskFunc(m,n) = {AckFunc(N, M)}");
