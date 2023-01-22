// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
int[] massive = GetRandomArray(size, 100, 999);
Console.WriteLine(string.Join(", ", massive));

int num = 0;
for(int i = 0; i < massive.Length; i++)
{
    if(massive[i]%2 == 0)
    {
        num += 1;
    }
}
Console.WriteLine($"Колличество четных чисел массива = {num}");
