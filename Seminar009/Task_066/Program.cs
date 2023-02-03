// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumers(int m, int n, int sum)
{
    if(m <= n)
    {
        sum = sum + n;
        sum = SumNumers(m, n - 1, sum);
    }
    return(sum);
}

Console.Write("Введите натуральное число М - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N - ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
sum = SumNumers(m, n, sum);

Console.Write($"Сумма натуральных элементов в промежутке от M до N = {sum}");