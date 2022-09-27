// Задача 1: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//ввод параметров с клавиатуры через передаваемое сообщение
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
//Рекурсивный вывод
void ShowNumbersRecursion(int number)
{
    if (number == 0) { return; }
    System.Console.Write($"{number} ");
    ShowNumbersRecursion(--number);
}
ShowNumbersRecursion(Prompt("Введите число > "));