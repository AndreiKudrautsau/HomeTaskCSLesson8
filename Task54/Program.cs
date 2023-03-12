// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int numRows = Prompt("Введите количество строк в массиве: ");
int numСols = Prompt("Введите количество столбцов в массиве: ");
int[,] newMatrix = CreateMatrix(numRows, numСols);
Console.WriteLine("Созданная Вами матрица:");
PrintMatrix(newMatrix);
Console.WriteLine();
MatrixSortRowMaxToMin(newMatrix);
Console.WriteLine("Созданная Вами матрица с отсортированными по убыванию элементами в строках имеет следующий вид:");
PrintMatrix(newMatrix);

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

void MatrixSortRowMaxToMin(int[,] matrix)
{
    int max = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            for (int index = 0; index < matrix.GetLength(1) - 1; index++)
            {
                if (matrix[i, index] < matrix[i, index + 1]) 
            {
                max = matrix[i, index + 1];
                matrix[i, index + 1] = matrix[i, index];
                matrix[i, index] = max;
                }
            }     
        }

    }
}