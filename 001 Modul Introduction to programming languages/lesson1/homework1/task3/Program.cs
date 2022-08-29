// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
int volum = Prompt("Введите первое число > ");
isEven();
void isEven()
{
    Console.Write($"{volum} ->");
    if (volum != 0)
    {
        if (volum % 2 == 0)
        {
            Console.Write(" да");

        }
        else
        {
            Console.WriteLine(" нет");
        }
    }
    else
    {
        System.Console.WriteLine(" Вы ввели нуль");
    }
}
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}