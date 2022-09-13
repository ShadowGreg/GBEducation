// Задача 1: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
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
    for (int i = 1; i < array.Length-1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length-1]}]");
}

const int MIN_ELEMENTS = 100;
const int MAX_ELEMENTS = 1000;

int length = Prompt("Введите длину массива > ");
int[] newArray = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(newArray);

int sumEvenNumbers(int[] inputArray)
{
    int sum = 0;
    foreach (var item in inputArray)
    {
        if (item % 2 == 0)
        {
            sum ++;
        }
    }
    return sum;
}
System.Console.WriteLine($" -> {sumEvenNumbers(newArray)}");