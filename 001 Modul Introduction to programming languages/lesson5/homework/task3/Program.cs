// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    System.Console.Write($"[{array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}]");
}

const int MIN_ELEMENTS = 0;
const int MAX_ELEMENTS = 99;

int length = Prompt("Введите длину массива > ");
int[] newArray = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(newArray);

int MaxElement(int[] inputArray)
{
    int max = 0;
    foreach (var item in inputArray)
    {
        if (item > max)
        {
            max = item;
        }
    }
    return max;
}
int MinElement(int[] inArray)
{
    int min = MaxElement(inArray);
    foreach (var item in inArray)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}
System.Console.WriteLine($" -> {MaxElement(newArray)-MinElement(newArray)}");