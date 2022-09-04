// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
string Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";    
    return strValue;
}

string inputValue = Prompt("Введите число > ");
var lastChar = inputValue[inputValue.Length-1];
System.Console.WriteLine(lastChar);