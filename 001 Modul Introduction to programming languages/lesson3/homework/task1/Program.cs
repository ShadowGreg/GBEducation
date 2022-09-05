// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


long Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    long value = long.Parse(strValue);
    return value;
}

long parseInt = Prompt("Введите число > ");

bool IsPalindromic(long inputInt)
{
    bool isPalindromic = false;
    long splitNum = inputInt;
    for (int i = 1; i <= inputInt.ToString().Length / 2; i++)
    {
        long endTail = splitNum % 10;
        long splitNumLength = splitNum.ToString().Length;
        long startTail = Convert.ToInt32(Math.Floor(splitNum / Math.Pow(10, splitNumLength - 1)));
        if (startTail == endTail)
        {
            isPalindromic = true;
        }
        else
        {
            isPalindromic = false;
            break;
        }
        splitNum = findSplitNum(splitNum);
        if (splitNum/10 == 0)
        {
            break;
        }
    }
    return isPalindromic;
}

long findSplitNum(long inputSplitedNum)
{ 
    long  outputSplitedNum = inputSplitedNum/10;
    long lengthInputInt = outputSplitedNum.ToString().Length;
    outputSplitedNum =  Convert.ToInt32(outputSplitedNum % Math.Pow(10,lengthInputInt-1));
    return outputSplitedNum;
}

string PrintAnswer(bool inputBool)
{
    string output = "ops";
    if (inputBool == true)
    {
        output = "да";
    }
    if (inputBool == false)
    {
        output = "нет";
    }
    return output;
}

System.Console.WriteLine($"{parseInt} -> {PrintAnswer(IsPalindromic(parseInt))}");