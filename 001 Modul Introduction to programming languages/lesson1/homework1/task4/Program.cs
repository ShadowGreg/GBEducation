// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
string isNull = " Число равно нулю";
string isNegative = " Число отрицательное";
int volum = Prompt("Введите первое число > ");
Print();

void Print()
{
    if (isPositive(volum))
    {
        Console.Write($"{volum} -> 2");
        for (int i = 4; i <= volum;)
        {
            Console.Write($", {i}");
            i = i + 2;
        }
    }
}
bool isPositive(int _volum)
{
    if (_volum > 0)
    {
        return true;
    }
    else if (_volum == 0)
    {
        IsNullExeption(_volum);
        return false;
    }
    else
    {
        System.Console.Write(isNegative);
        return false;
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
void IsNullExeption(int _volum)
{
    if (_volum == 0)
    {
        System.Console.Write(isNull);
    }
}

