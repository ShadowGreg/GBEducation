// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//Ввод параметров 
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber && value > 0)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в колонки либо строки");
}
//Генерация матрицы 
int[,] GenerateMatrix(int rowLength, int colLength, int minRange, int maxRange)
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
//Сортировка внутри строк подаваемой матрицы
void RowSort(int[,] inputMatrix, int rowIndex)
{
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1) - 1; j++)
        {
            if (inputMatrix[rowIndex, j] > inputMatrix[rowIndex, j + 1])
            {
                int t = inputMatrix[rowIndex, j + 1];
                inputMatrix[rowIndex, j + 1] = inputMatrix[rowIndex, j];
                inputMatrix[rowIndex, j] = t;
            }
        }
    }
}
// Сортировка всей матрицы с использованием функции сортировки строк
void MatrixSort(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        RowSort(inputMatrix, i);
    }
}
//Печать матрицы
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
//Основная программа
int[] inputMatrixParam = new int[4];
inputMatrixParam[0] = Prompt("Введите количество строк > ");
inputMatrixParam[1] = Prompt("Введите количество колонок > ");
int minRange = 1;
inputMatrixParam[2] = minRange;
int maxRange = 10;
inputMatrixParam[3] = maxRange;
int[,] newMatrix = GenerateMatrix
(
    inputMatrixParam[0],
    inputMatrixParam[1],
    inputMatrixParam[2],
    inputMatrixParam[3]
);
System.Console.WriteLine("Исходная матрица:");
PrintMatrix(newMatrix);
MatrixSort(newMatrix);
System.Console.WriteLine("Сортированная матрица:");
PrintMatrix(newMatrix);