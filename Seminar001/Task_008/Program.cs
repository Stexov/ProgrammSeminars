//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < number - 1)
{
    count = count + 2;
    Console.Write(count);
    Console.Write(", ");
}
Console.WriteLine("");
Console.WriteLine("Закончен вывод четных чисел удолетворяющих условию");