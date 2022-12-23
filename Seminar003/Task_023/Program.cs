// Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int result = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= result; i++)
{
    Console.WriteLine($"Куб числа {i} = {i*i*i}");
}