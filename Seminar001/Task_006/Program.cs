//Напишите программу, которая на вход принимает число и выдает,
//является ли число четным (делится ли оно на два без остатка).

Console.Write("Введите любое число: ");
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
