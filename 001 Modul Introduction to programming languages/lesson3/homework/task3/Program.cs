// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int inputInt = Prompt("Введите число > ");
MakeLine(inputInt);

void MakeLine(int inputNum)
{
    System.Console.WriteLine();
    System.Console.Write($"{inputNum} -> {1}");
    for (int i = 2; i <= inputNum; i++)
    {
        PrintItem(", ",i);
    }    
}

void PrintItem(string start, int inputCount)
{
    System.Console.Write($"{start}{Math.Pow(inputCount, 3)}");
}