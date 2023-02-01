// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetRandomMatrix(int rows, int column, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, column];

    int Ibeg = 0;
    int Ifin = 0;
    int Jbeg = 0;
    int Jfin = 0;
    
    int k = 0;
    int i = 0;
    int j = 0;

    while (k <= rows * column - 1)
    {
        matrix[i, j] = leftRange;
        if (i == Ibeg && j < column - Jfin - 1)
            ++j;
        else if (j == column - Jfin - 1 && i < rows - Ifin - 1)
            ++i;
        else if (i == rows - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != column - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++leftRange;
        ++k;
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
const int columns = 5;
const int leftRange = 40;
const int rightRange = 100;

Console.WriteLine("Спиральный массив");
int[, ] matrix= GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(matrix);