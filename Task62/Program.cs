// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int numRows = Prompt("Введите размерность квадратной матрицы: ");
int[,] matrixNew = CreateMatrixInt(numRows);
PrintMatrix(matrixNew, numRows);



// методы
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateMatrixInt(int rows)
{
    int[,] matrix = new int[rows, rows];
    int numR = matrix.GetLength(0);
    int numC = matrix.GetLength(1);
    int size = rows * rows;
    int firstIndexRows = 0;
    int firstIndexCols = 0;
    int firstCol = 0;
    int lastRow = numR - 1;
    int lastCol = numC - 1;
    int number = 1;

    while (number <= size)
    {
        for (int i = firstIndexRows, j = firstIndexCols; j < lastCol + 1; j++) // left - right
        {
            matrix[i, j] = number;
            number++;
        }
        firstIndexRows++;
        firstIndexCols++;

        for (int i = firstIndexRows, j = lastCol; i < lastRow + 1; i++) // right up - down
        {
            matrix[i, j] = number;
            number++;
        }
        lastCol--;

        for (int i = lastRow, j = lastCol; j > firstCol - 1; j--) // right - left
        {
            matrix[i, j] = number;
            number++;
        }
        lastRow--;
        
        for (int i = lastRow, j = firstCol; i > firstIndexRows - 1; i--) // down - up
        {
            matrix[i, j] = number;
            number++;
        }

        firstCol++;
        
        
    }

    return matrix;
}



void PrintMatrix(int[,] matrix, int num)
{
    Console.WriteLine($"Матрица {num} x {num}, заполненная спирально, имеет следующий вид:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"0{matrix[i, j]}     ");
            else Console.Write($"{matrix[i, j]}     ");
        }
        Console.WriteLine();
    }
}