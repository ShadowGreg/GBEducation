// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int firstNum = Prompt("Введите первое число > ");
int secondNum = Prompt("Введите первое число > ");
if (firstNum != secondNum)
{
    if (firstNum > secondNum)
    {
        PrintMax(firstNum , secondNum, firstNum);
    }
    if (firstNum < secondNum)
    {
        PrintMax(firstNum , secondNum, secondNum);
    }
}
else
{
    System.Console.WriteLine($"a = {firstNum}; b = {secondNum} -> числа равны, максимального нет");
}

void PrintMax(int a, int b, int max)
{
    System.Console.WriteLine($"a = {a}; b = {b} -> max = {max}");
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