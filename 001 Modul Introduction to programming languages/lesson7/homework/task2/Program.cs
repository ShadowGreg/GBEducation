// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int Prompt(string massage) // Массаж? Ахахах! "massage"! Input of values.
{
    Console.Write(massage);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber && value > 0)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в колонки либо строки");
}

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

void FindItem(int[,] inputMatrix, int rows, int columns) // "columns" Find element in matrix.
{
    if (rows - 1 > inputMatrix.GetLongLength(0) | columns - 1 > inputMatrix.GetLongLength(1))
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        System.Console.WriteLine($" искомое число: {inputMatrix[rows - 1, columns - 1]}");
    }
}

void PrintArray(int[,] array) // Prints a matrix.
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

int[,] newMatrix = GenerateMatrix(4, 5, -10, 10);
PrintArray(newMatrix);
int inputRows = Prompt("Введите строку искомого элемента > ");
int inputColumns = Prompt("Введите колонку искомого элемента > "); // "колонку"!
FindItem(newMatrix, inputRows, inputColumns); // "Columns"!
// https://qna.habr.com/q/630783 spelling check, i think a must have.
