// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

int FibonacciNum(int number)
{
    if (number == 0)
    {
        return 0;
    }
    int num   = 0;
    int numFirst = 1;
    int numSecond = 0;

    for (int i =  1; i <= number; i++)
    {
        System.Console.WriteLine(num);
        numSecond = num + numFirst;
        num = numFirst;
        numFirst = numSecond;
         
    }
    return numSecond;
}
int number = Prompt("Введите номер последовательности Фибоначчи: ");
FibonacciNum(number);
