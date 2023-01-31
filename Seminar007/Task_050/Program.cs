// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetRandomMatrix(int rows, int column, int leftRange, int rightRange)
{
    int[, ] matrix = new int[rows, column];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange);
        }
    } 
    return(matrix);
}

void PrdoubleMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    } 
}
const int rows = 4;
const int columns = 4;
const int leftRange = 0;
const int rightRange = 100;

Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
int n = (num - 1) / rows;
int m = (num - 1) % rows;

int[, ] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(array);

if(num > rows * columns)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Элемент массива с номером {num} = {array[n, m]}");
}
