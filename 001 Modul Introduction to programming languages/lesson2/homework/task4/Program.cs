// Задача 4: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
string[] days =
{
     "рабочий", "рабочий", "рабочий", "рабочий", "рабочий",
     "выходной", "выходной"
};
int parseInt = Prompt("Введите день недели > ");

if (parseInt > 0 && parseInt < 8)
{
    int index = parseInt - 1;
    System.Console.WriteLine($"День под номером {parseInt} -> {days[index]}");
    if (days[index] == "выходной")
    {
        System.Console.WriteLine("Поздравляю! Вы нашли выходной день!");
    }
}
else
{
    System.Console.WriteLine("Нет такого дня недели!");
}

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
