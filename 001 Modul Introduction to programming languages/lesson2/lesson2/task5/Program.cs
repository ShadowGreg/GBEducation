// 3.1. Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4
int[] numbers = new int[5];

System.Console.WriteLine(numbers.Sum());
System.Console.WriteLine(numbers.Average());

for (int i = 0; i< numbers.Lengh; i++)
{
numbers[i] = Prompt($"Введит {i}-ое число > ");
}

int Prompt(string messege) 
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
