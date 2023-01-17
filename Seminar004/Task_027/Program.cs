// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int res = 0;
while (number != 0)
{
    res = res + number % 10;
    number = number / 10;
}
 Console.WriteLine($"Сумма цифр числа = {res}");