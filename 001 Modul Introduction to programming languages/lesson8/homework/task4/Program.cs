//Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }

    throw new Exception("Вы ввели не число");
}
//Спиральное заполнение матрицы
int[,] FillSpiralMatrix(int matrixDim)
{
    int[,] answerMatrix = new int[matrixDim, matrixDim];
    int rowIterator = 0;
    int columnIterator = 0;
    int sum = 1;
    bool increment = true;
    for (int i = 0; i < matrixDim; i++)
    {
        answerMatrix[rowIterator, columnIterator] = sum;
        if (increment)
        {
            while (columnIterator + 1 < matrixDim && answerMatrix[rowIterator, columnIterator + 1] == 0)
                answerMatrix[rowIterator, ++columnIterator] = ++sum;
            while (rowIterator + 1 < matrixDim && answerMatrix[rowIterator + 1, columnIterator] == 0)
                answerMatrix[++rowIterator, columnIterator] = ++sum;
        }
        else
        {
            while (columnIterator > 0 && answerMatrix[rowIterator, columnIterator - 1] == 0)
                answerMatrix[rowIterator, --columnIterator] = ++sum;
            
            while (rowIterator > 0 && answerMatrix[rowIterator - 1, columnIterator] == 0)
                answerMatrix[--rowIterator, columnIterator] = ++sum;
        }
        increment = !increment;
    }
    return answerMatrix;
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
int matrixDimension = Prompt("Введите размерность квадратной матрицы > ");
int[,] newMatrix = FillSpiralMatrix(matrixDimension);
PrintMatrix(newMatrix);