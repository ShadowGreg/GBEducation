// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int[] numbers = new int[3];

Input();
Print();

void Print()
{
    int length = numbers.Length;
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
    Console.WriteLine($"{numbers[length - 1]} -> {numbers.Max()}");
}

void Input()
{
    int length = numbers.Length;
    for (int i = 0; i < length; i++)
    {
        numbers[i] = Prompt($"Введите {i + 1}ое число > ");
    }
}

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}