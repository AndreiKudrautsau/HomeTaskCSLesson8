// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int numRowsMatrixOne = Prompt("Введите количество строк в матрице № 1: ");
int numСolsMatrixOne = Prompt("Введите количество столбцов в матрице № 1: ");
int[,] newMatrixOne = CreateMatrix(numRowsMatrixOne, numСolsMatrixOne);
int numRowsMatrixTwo = Prompt("Введите количество строк в матрице № 2: ");
int numСolsMatrixTwo = Prompt("Введите количество столбцов в матрице № 2: ");
int[,] newMatrixTwo = CreateMatrix(numRowsMatrixTwo, numСolsMatrixTwo);
Console.WriteLine("Созданная Вами матрица № 1:");
PrintMatrix(newMatrixOne);
Console.WriteLine("Созданная Вами матрица № 2:");
PrintMatrix(newMatrixTwo);
Console.WriteLine();
if (numRowsMatrixOne != numRowsMatrixTwo) Console.WriteLine("Для умножения массивов количество столбцов в массиве № 1 должно быть равно количеству строк в массиве № 2");
else 
{
    int[,] newMultiplyMatrix = MultiplyMatrixes(newMatrixOne, newMatrixTwo);
    Console.WriteLine("Если умножить матрицу № 1 на матрицу № 2, получим следующий результат:");
    PrintMatrix(newMultiplyMatrix);
}


// методы
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] CreateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrixes(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixMultiply = new int[matrixOne.GetLongLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int m = 0; m < matrixOne.GetLength(1); m++)
            {
                matrixMultiply[i, j] += matrixOne[i, m] * matrixTwo[m, j];
            }
        }
    }
    return matrixMultiply;
}