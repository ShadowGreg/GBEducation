// Задача 1: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число > ");

int Validation(int inputPromt)
{
    if (inputPromt < 0)
    {
        System.Console.WriteLine("Отрицательное число, перевожу в положительное");        
        number = Math.Abs(inputPromt);
    } 
   return inputPromt; 
}


int CountDigit(int inputNum)
{
    int count = 1;
    int result = Validation(inputNum) / 10;
    while (result > 0)
    {
        result = result / 10;
        count++;
    }
    return count;
}
System.Console.WriteLine($"{number} -> {CountDigit(number)}");