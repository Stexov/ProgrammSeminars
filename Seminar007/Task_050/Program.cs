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
const int rows = 5;
const int columns = 4;
const int leftRange = 10;
const int rightRange = 100;

Console.WriteLine("Введите номер строки");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int numColumns = Convert.ToInt32(Console.ReadLine());

if(numRows > rows || numColumns > columns)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    int[, ] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
    PrdoubleMatrix(array);
    Console.WriteLine();
    Console.WriteLine($"Искомый элемент массива = {array[numRows - 1, numColumns - 1]}");
}