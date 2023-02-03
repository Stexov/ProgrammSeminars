// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

void Metod(int n, int m)
{
    if(m == n + 1) return;
    {
        Metod(n, m + 1);
        Console.Write($"{m}, ");        
    }
}

Console.Write("Введите натуральное число - ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
Metod(n, m);