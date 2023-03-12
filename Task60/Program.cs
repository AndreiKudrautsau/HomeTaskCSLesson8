// Задача 60. ...
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int numRowsMatrix = Prompt("Введите первый размер массива: ");
int numСolsMatrix = Prompt("Введите второй размер массива: ");
int numDepthMatrix = Prompt("Введите третий размер массива: ");
int firstNumberMatrix = Prompt("Введите двузначное число - начало массива неповторяющихся двузначных чисел: ");
int[,,] new3dMatrix = CreateMatrix(numRowsMatrix, numСolsMatrix, numDepthMatrix, firstNumberMatrix);
int firstNumberMatrixPerfect = 99 - numRowsMatrix * numСolsMatrix * numDepthMatrix;
if (firstNumberMatrix <= firstNumberMatrixPerfect && firstNumberMatrix > 9) 
{
    Console.WriteLine("Вы создали следующую матрицу:");
    PrintMatrix(new3dMatrix);
}
else if (firstNumberMatrix > firstNumberMatrixPerfect || firstNumberMatrix <= 9) 
Console.WriteLine($"Для создания массива неповторяющихся двузначных чисел разменостью {numRowsMatrix} * {numСolsMatrix} * {numDepthMatrix} число должно быть меньше либо равно {firstNumberMatrixPerfect} и больше 9");
    

Console.WriteLine();

// методы
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,,] CreateMatrix(int rows, int cols, int depth, int numberDual)
{
    int[,,] matrix = new int[rows, cols, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                matrix[i, j, m] = ++numberDual;
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
        {
            Console.Write($"{matrix[i, j, m]} ({i}, {j}, {m}) ");
        }
        }
        Console.WriteLine();
    }
}
