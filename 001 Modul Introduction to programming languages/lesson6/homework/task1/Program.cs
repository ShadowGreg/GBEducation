// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число, переввдите.");
}

int[] InputArray()
{
    int length = Prompt("Введите количество чисел в последовательности > ");
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-е число > ");
    }
    return array;
}

int FindPosistive(int[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

void MainTest()
{
    int[] firstTestArray = new int[]{0, 7, 8, -2, -2};
    int[] secondTestArray = new int[]{1, -7, 567, 89, 223};
    PrintArray(firstTestArray);
    System.Console.WriteLine($" -> {FindPosistive(firstTestArray)}, Expected 2");
    System.Console.WriteLine();
    PrintArray(secondTestArray);
    System.Console.WriteLine($" -> {FindPosistive(secondTestArray)}, Expected 4");
    System.Console.WriteLine();
}

MainTest();
int[] mainArray = InputArray();
PrintArray(mainArray);
System.Console.WriteLine("В вашей боследовательности -> количество чисел больше нуля");
System.Console.WriteLine($" -> {FindPosistive(mainArray)}");
