﻿Console.Write("Введите любое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = number1 % 2;
if (result == 0)
{
    Console.Write("Введенное число является четным: ");
}
else
{
    Console.Write("Веденное число не является четным");
}
