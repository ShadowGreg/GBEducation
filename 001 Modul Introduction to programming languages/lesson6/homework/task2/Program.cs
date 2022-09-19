// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1,
//   y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double Prompt(string message)
{
    Console.Write(message);
    bool isDigit = double.TryParse(Console.ReadLine(), out double number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

double[] InputCoefficeents()
{
    double[] inputArray = new double[4];
    for (int i = 0; i < 3; i += 2)
    {
        if (i < 2)
        {
            inputArray[i] = Prompt($"Введите b1 > ");       //0
            inputArray[i + 1] = Prompt($"Введите k1 > ");   //1
        }
        else
        {
            inputArray[i] = Prompt($"Введите b2 > ");       //2
            inputArray[i + 1] = Prompt($"Введите k2 > ");   //3
        }
    }
    return inputArray;
}

double[] Answer(double[] inputLines)
{
    const int B1 = 0;
    const int K1 = 1;
    const int B2 = 2;
    const int K2 = 3;
    double[] outputCoordinates = new double[2];
    if (inputLines[K1] != inputLines[K2])
    {
        outputCoordinates[0] = (inputLines[B2] - inputLines[B1]) / (inputLines[K1] - inputLines[K2]);
        outputCoordinates[1] = inputLines[K1] * outputCoordinates[0] + inputLines[B1];
        return outputCoordinates;
    }
    else
    {
        System.Console.Write("Вы задали параллельные прямые! ");
        return new double[] { 0 };
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
}

void MainTest()
{
    System.Console.WriteLine("Tests");
    #region InTheTask
    double[] inputArray = new double[4] { 2, 5, 4, 9 };
    System.Console.Write("  Answer: ");
    PrintArray(Answer(inputArray));
    System.Console.WriteLine();
    System.Console.WriteLine("Expected: -0,5; -0,5;");
    #endregion
    #region ParallelLines
    inputArray = new double[4] { 2, 5, 4, 5 };
    System.Console.Write("  Answer: ");
    PrintArray(Answer(inputArray));
    System.Console.WriteLine();
    System.Console.WriteLine("Expected: Вы задали параллельные прямые! 0;");
    System.Console.WriteLine();
    #endregion
}
MainTest();
System.Console.WriteLine("Координаты точки пересечения Х, У:");
double[] inLines = InputCoefficeents();
PrintArray(Answer(inLines));
