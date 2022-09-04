// Задача 1: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
int parseInt = Prompt("Введите число > ");
System.Console.WriteLine($"{parseInt} вторая цифра этого числа -> {findSecondInt(parseInt)}");

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int findSecondInt(int inputInt)
{
    if (inputInt > 99)
    {

        int tailInt = inputInt % 10;
        int tempInt = inputInt / 10;
        while (tempInt > 10)
        {
            tailInt = tempInt % 10;
            tempInt = tempInt / 10;
        }
        return tailInt;
    }    
    throw new Exception("Число должно быть больше 99!");    
}