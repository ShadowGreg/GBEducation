// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
//Ввод данных в программе 
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
// Генерация матрицы
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
//Нахождение суммы в строках
int FindSum(int[,] inputMatrix, int rowIndex)
{
    int sum = 0;
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        sum += inputMatrix[rowIndex, i];
    }
    return sum;
}
// Заполнение одномерного массива суммами
int[] FillArraySum(int[,] inputMatrix)
{
    int[] arraySum = new int[inputMatrix.GetLength(0)];
    for (int i = 0; i < arraySum.Length; i++)
    {
        arraySum[i] = FindSum(inputMatrix, i);
    }
    return arraySum;
}
//Нахождение индекса минимального элемента
int FindMinIndex(int[] inputArray)
{
    int min = inputArray[0];
    int minIndex = -1;
    for (int i = 1; i < inputArray.Length; i++)
    {
        if (inputArray[i] < min)
        {
            min = inputArray[i];
            minIndex = i;
        }
    }
    return minIndex;
}
//Печать одномерного массива сумм
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"В {i}-ой строке сумма = {array[i]};");
    }
}
// Печать матрицы
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
PrintArray(FillArraySum(newMatrix));
System.Console.WriteLine
(
    $"Индекс строки с минимальной суммой: {FindMinIndex(FillArraySum(newMatrix))}"
);