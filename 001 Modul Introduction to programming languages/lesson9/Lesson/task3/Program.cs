// Задача 3: Напишите программу, которая будет принимать на вход число и 
//возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int SumOfDigit(int number)
{
    if (number <= 0) {return 0;}
    return number%10 + SumOfDigit(number/10);
}

int num = Prompt("Введи число: ");
System.Console.WriteLine($"{SumOfDigit(num)}");
