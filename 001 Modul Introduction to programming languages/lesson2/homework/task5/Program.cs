// Задача 5 *: Напишите программу, которая генерирует 
//несколько случайных чисел, и в цикле проверяет, кратны ли эти числа 
//предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да
int parseInt = Prompt("Введите число > ");
if (parseInt != 0)
{
    isMultiple();
}
else
{
    System.Console.WriteLine("Число должно быть не равно нулю");
}


void isMultiple()
{
    bool isTrue = true;
    while (isTrue)
    {
        int randomGen = new Random().Next();
        if (randomGen % parseInt != 0)
        {
            System.Console.WriteLine($"{randomGen} -> нет");
        }
        else
        {
            System.Console.WriteLine($"{randomGen} -> да");
            isTrue = false;
        }
        Thread.Sleep(300);
    }
}

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
