// Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Ввдетите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers < 0)
{
    numbers = numbers * -1;
}
if (numbers < 100)
{
    Console.WriteLine("Введенное число не является трехзначным"); 
}
while (numbers > 999)
{
    numbers = numbers / 10;
}
numbers = numbers % 10;
Console.WriteLine($"Искомое число = {numbers}");