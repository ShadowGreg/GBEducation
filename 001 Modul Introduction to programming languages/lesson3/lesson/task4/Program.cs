// Задача 4: Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void Square(int number)
{
    int index = 1;
    while (index <= number)
    {
        System.Console.WriteLine($"Квадрат числа {index} это {index * index}");
        index++;
    }
}
int number = Prompt("Введите число:");
Square(number);
