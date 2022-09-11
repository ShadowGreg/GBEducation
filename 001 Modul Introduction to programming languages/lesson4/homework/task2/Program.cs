// Задача 2: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    var vale = int.Parse(strValue);
    return vale;
}

int inputNumber = Prompt("Введите число > ");

int MakeSumFigure(int inNumber)
{
    if (inNumber < 0)
    {
        inNumber = Math.Abs(inNumber);
    }
    int sum = 0;
    int tempNumder = inNumber;
    int tempFigure;
    while (tempNumder > 0)
    {
        tempFigure = tempNumder % 10;
        tempNumder = tempNumder / 10;
        sum = sum + tempFigure;
    }
    return sum;
}

System.Console.WriteLine($"{inputNumber} -> {MakeSumFigure(inputNumber)}");