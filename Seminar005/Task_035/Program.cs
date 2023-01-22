// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] massive = GetRandomArray(123, 0, 150);
int num = 0;
for(int i = 0; i < massive.Length; i++)
{
    if(massive[i] > 10 && massive[i] < 100)
    {
        num += 1;
    }
}
Console.WriteLine($"Колличество чисел массива в диапазоне от 10 до 99 = {num}");