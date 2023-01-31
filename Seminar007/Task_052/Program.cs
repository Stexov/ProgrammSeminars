// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write(matrix[i, j] + "    ");
        }
        Console.WriteLine();
    } 
}

double[] AverageArithmetic(int[,] array, int rows, int columns)
{
    double[] arrayArithmetic = new double[columns];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            arrayArithmetic[j] = arrayArithmetic[j] + array[i, j];
        }
        arrayArithmetic[j] = arrayArithmetic[j] / rows;
    }
    return(arrayArithmetic);
}
void PrintMatrix(double[] arrayArithmetic, int columns)
{
    for(int i = 0; i < columns; i++)
    {
        Console.Write(arrayArithmetic[i] + " ");
    } 
}


const int rows = 4;
const int columns = 4;
const int leftRange = 0;
const int rightRange = 100;

int[, ] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(array);
double[] arrayArithmetic = AverageArithmetic(array, rows, columns);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов");
Console.WriteLine();
PrintMatrix(arrayArithmetic, columns);

