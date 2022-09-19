// Задача 3: (*)
// Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

using System.Threading.Channels;

int[,] FillMatrix()
{
    int[,] matrix = new int[2, 3];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }

    return matrix;
}

const int ROWS = 0;
const int COLUMS = 1;

int[] FindMaxInRows(int[,] inMatrix)
{
    int[] maxArray = new int[inMatrix.GetLength(ROWS)];
    int[] tempArray = new int[inMatrix.GetLength(COLUMS)];
    for (int i = 0; i < inMatrix.GetLength(ROWS); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(COLUMS); j++)
        {
            tempArray[j] = inMatrix[i, j];
        }

        maxArray[i] = FindMax(tempArray);
    }

    return maxArray;
}

int FindMax(int[] inputArray)
{
    int max = inputArray[0];
    foreach (var item in inputArray)
    {
        if (item > max)
        {
            max = item;
        }
    }

    return max;
}

int[] FindMinInColumns(int[,] inMatrix)
{
    int[] minArray = new int[inMatrix.GetLength(COLUMS)];
    int[] tempArray = new int[inMatrix.GetLength(ROWS)];
    for (int i = 0; i < inMatrix.GetLength(COLUMS); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(ROWS); j++)
        {
            tempArray[j] = inMatrix[j, i];
        }

        minArray[i] = FindMin(tempArray);
    }

    return minArray;
}

int FindMin(int[] inputArray)
{
    int min = inputArray[0];
    foreach (var item in inputArray)
    {
        if (item < min)
        {
            min = item;
        }
    }

    return min;
}

int FindSum(int[] inputArray)
{
    int sum = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        sum = sum + inputArray[i];
    }

    return sum;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }

        System.Console.WriteLine();
    }

    System.Console.WriteLine();
}

void PrintSum(int[] printArray, int sumAnswer)
{
    for (int i = 0; i < printArray.Length - 1; i++)
    {
        Console.Write($"{printArray[i]}+");
    }

    Console.Write($"{printArray[printArray.Length - 1]}=");
    Console.Write($"{sumAnswer}\t");
}

int[,] newMatrix = FillMatrix();
PrintMatrix(newMatrix);
int[] maxArray = FindMaxInRows(newMatrix);
int[] minArray = FindMinInColumns(newMatrix);
int maxSum = FindSum(maxArray);
int minSum = FindSum(minArray);
PrintSum(maxArray, maxSum);
PrintSum(minArray, minSum);
Console.Write($" {maxSum}-{minSum}={maxSum - minSum}");