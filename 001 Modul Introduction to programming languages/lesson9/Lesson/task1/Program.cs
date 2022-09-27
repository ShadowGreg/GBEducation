// Задача 1: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber && value > 0)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать целый тип");
}

void ShowNumber(int number)
{
    if (number == 0){return;} 
   // System.Console.Write($"{number} ");
    ShowNumber(--number);
    System.Console.Write($"{number} ");
}
ShowNumber(Prompt("Введите число > "));