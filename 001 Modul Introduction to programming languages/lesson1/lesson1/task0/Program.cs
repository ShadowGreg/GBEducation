int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число > ");
int result = value * value;
Console.WriteLine($"Квадрат числа {value} равен {result}");
