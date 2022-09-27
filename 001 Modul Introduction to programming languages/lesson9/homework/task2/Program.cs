// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
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
//поиск рекурсией суммы между числами
int FindRecursionSum(int inStartNum, int inEndNum)
{
    if (inStartNum == inEndNum)
    {
        return 0;
    }
    inStartNum++;
    return (inStartNum + FindRecursionSum(inStartNum, inEndNum));
}
//Основная программа
int startNum = Prompt("Введите начало промежутка > ");
int endNum = Prompt("Введите конец промежутка > ");
const int CORRECTION_INDEX = 1;
int sum = FindRecursionSum(startNum - CORRECTION_INDEX, endNum);
System.Console.WriteLine($" -> {sum}");