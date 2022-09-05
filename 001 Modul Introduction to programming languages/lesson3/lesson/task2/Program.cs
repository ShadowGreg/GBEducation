// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int inputNum)
{
    if (inputNum > 0 && inputNum < 5)
    {
        return true;
    }

    System.Console.WriteLine("Такой четверти нет");
    return false;
}

void DeterminateQuarter(int inputQuarter)
{
    if (inputQuarter == 1)
    {
        System.Console.WriteLine("x > 0 && y > 0");
    }
    if (inputQuarter == 2)
    {
        System.Console.WriteLine("x < 0 && y > 0");
    }
    if (inputQuarter == 3)
    {
        System.Console.WriteLine("x < 0 && y < 0");
    }
    if (inputQuarter == 4)
    {
        System.Console.WriteLine("x > 0 && y < 0");
    }
}

int qNumber = Prompt("Введите номер четверти > ");

if (ValidateCoords(qNumber))
{
    DeterminateQuarter(qNumber);
}
