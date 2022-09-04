// Задача 3: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
int parseInt = Prompt("Введите число > ");
if (parseInt > 99)
{

    int tailInt = parseInt % 10;
    int tempInt = parseInt / 10;
    while (tempInt > 100)
    {
        tailInt = tempInt % 10;
        tempInt = tempInt / 10;
    }
    System.Console.WriteLine($"В числе {parseInt} третья цифра {tailInt}");
}
else
{
    System.Console.WriteLine($"В числе {parseInt} нет третьей цифры");
}


int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

