// 3. Напишите программу вычисления функции куба:
//  x = f(a)

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int value = Prompt("Введите число > ");
System.Console.WriteLine(value*value*value);