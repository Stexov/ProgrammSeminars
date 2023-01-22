// Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}
Console.WriteLine("Задайте размер масива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте нижнюю границу масива");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте верхнюю границу масива");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] massive = GetRandomArray(size, leftRange, rightRange);

int max = massive[0];
int min = massive[0];
for(int i = 1; i < massive.Length; i++)
{
    if (massive[i] > max)
    {
        max = massive[i];
    }
    if (massive[i] < min)
    {
        min = massive[i];
    }
}
int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {result}");