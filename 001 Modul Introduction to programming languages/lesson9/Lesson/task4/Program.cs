// Задача 4: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int PowOfNumber(int num, int pow)
{
    if(pow <=0){return 1;}
    return num * PowOfNumber(num, pow - 1);
}

int number = Prompt("Введите число: ");
int pow = Prompt("Введите степень: "); 
System.Console.WriteLine($"Число {number} в степени {pow} = {PowOfNumber(number, pow)}");
