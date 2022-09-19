// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateMatrix(int rowLength, int colLength, int minRange, int maxRange) // Generation of matrix.
{
    var array = new int[rowLength, colLength];
    var random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minRange, maxRange + 1);

        }
    }
    return array;
}

void PrintMatrix(int[,] array) // Print matrix.
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

int[] ReturnColumn(int[,] insertMatrix, int columnIndex) // Column!
{
    int[] column = new int[insertMatrix.GetLength(0)];
    for (int i = 0; i < insertMatrix.GetLength(0); i++)
    {
        column[i] = insertMatrix[i, columnIndex];
    }
    return column;
}

double FindArithmeticMean(int[] inputArray) // Calculation of arithmetic mean.
{
    double sum = 0;
    foreach (var t in inputArray)
    {
        sum = sum + t;
    }
    return sum / inputArray.Length;
}

int[,] newMatrix = GenerateMatrix(5, 5, -10, 10); // MAGIC numbers. Why not to input them? And there is no check for elements.
PrintMatrix(newMatrix);
for (int i = 0; i < newMatrix.GetLength(1); i++)
{
    System.Console.Write($"{FindArithmeticMean(ReturnColumn(newMatrix, i)):f1}\t");
}
