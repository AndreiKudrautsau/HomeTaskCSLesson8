// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int numRows = Prompt("Введите количество строк в массиве: ");
int numСols = Prompt("Введите количество столбцов в массиве: ");
int[,] newMatrix = CreateMatrix(numRows, numСols);
Console.WriteLine("Созданная Вами матрица:");
PrintMatrix(newMatrix);
Console.WriteLine();
int[] newArray = ArraySumElementsRowMatrix(newMatrix);
// Console.WriteLine();
// PrintArray(newArray);
int indexRowMinSum = FindIndexMinSumElementsRowMatrix(newArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов в Вашем массиве - > {indexRowMinSum}");

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int[] ArraySumElementsRowMatrix(int[,] matrix)
{
    int[] arraySumRowsMatrix = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int index = 0; index < matrix.GetLength(1); index++)
            {

                sum = sum + matrix[i, index];

            }
            arraySumRowsMatrix[i] = sum;
        }

    }
    return arraySumRowsMatrix;
}

int FindIndexMinSumElementsRowMatrix(int[] array)
{
    int minSumIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [minSumIndex] > array[i]) minSumIndex = i;
    }
    return minSumIndex + 1;
}