// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
//Ввод данных типа int через подаваемое сообщение
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
//Генерация двумерной матрицы 
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
//Ввод параметров двух матриц
int[,] InputMatrixParam()
{
    int[,] newParam = new int[2, 2];
    for (int i = 0; i < newParam.GetLength(0); i++)
    {
        newParam[i, 0] = Prompt($"Введите количество строк {i + 1} матрицы > ");
        newParam[i, 1] = Prompt($"Введите количество колонок {i + 1} матрицы > ");
    }
    return newParam;
}
//Поиск произведения матриц
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int xRows, xCols;
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        xRows = matrixA.GetLength(0);
        xCols = matrixB.GetLength(1);
    }
    else
        throw new Exception
        (
            "Не соблюдается условие для перемножения матриц"
        );
    int[,] matrixX = new int[xRows, xCols];
    int dotProductCount = matrixA.GetLength(1);
    int threadIndex = 0;
    for (int i = 0; i < xRows; i++)
    {
        for (int j = 0; j < xCols; j++)
        {
            matrixX[i, j] = CalculatePosition(threadIndex, dotProductCount,
            matrixX, matrixA, matrixB);
            threadIndex++;
        }
    }
    return matrixX;
}
//Вычисление элемента новой матрицы
int CalculatePosition(int index, int dotProductCount,
int[,] matrixX, int[,] matrixA, int[,] matrixB)
{
    int xRows = matrixX.GetLength(0);
    int xCols = matrixX.GetLength(1);
    int col = index % xRows;
    int row = (index - col) / xCols;
    int total = 0;
    for (int i = 0; i < dotProductCount; i++)
    {
        int a = matrixA[row, i];
        int b = matrixB[i, col];
        total += a * b;
    }
    return total;
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
//Основная часть кода
int[,] matrixParam = InputMatrixParam();
int minRange = 0;
int maxRange = 10;
int firsMatrix = 0;
int secondMatrix = 1;
int rows = 0;
int columns = 1;
int[,] matrixA = GenerateMatrix
(
    matrixParam[firsMatrix, rows],
    matrixParam[firsMatrix, columns],
    minRange,
    maxRange
);
int[,] matrixB = GenerateMatrix
(
    matrixParam[secondMatrix, rows],
    matrixParam[secondMatrix, columns],
    minRange,
    maxRange
);
System.Console.WriteLine("Первая матрица:");
PrintMatrix(matrixA);
System.Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixB);
System.Console.WriteLine("Результирующая матрица:");
PrintMatrix(MatrixMultiplication(matrixA, matrixB));