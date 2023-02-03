// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    }
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}

Console.Write("Введите натуральное число М - ");
int n = Convert.ToInt32((Console.ReadLine()));
Console.Write("Введите натуральное число N - ");
int m = Convert.ToInt32((Console.ReadLine()));
int k = recursion(n, m);
Console.WriteLine($"Результа вычисления функции Аккермана = {k}");