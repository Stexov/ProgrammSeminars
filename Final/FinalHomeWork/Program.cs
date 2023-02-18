// Задача 31: Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void ArraySource(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int s = array[i].Length;
        if( s <= 3)
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Ввдедите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] arrayInit = new string[n];
for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Ввдедите элемент массива - {i + 1}");
    arrayInit[i] = new string(Console.ReadLine());
}


Console.WriteLine("Исходный массив");
PrintArray(arrayInit);
Console.WriteLine("Искомый массив");
ArraySource(arrayInit);

 

// int[] massive = GetRandomArray(12, -9, 9);
// Console.WriteLine(string.Join(", ", massive));

// int sumP = 0;
// int sumN = 0;
// for(int i = 0; i < massive.Length; i++)
// {
//     if(massive[i] > 0)
//     {
//         sumP += massive[i];
//     }
//     else
//     {
//         sumN += massive[i];
//     }
// }
Console.WriteLine(arrayInit);
//Console.WriteLine($"Сумма отрицательных чисел = {sumN}");