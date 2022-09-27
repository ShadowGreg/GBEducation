// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”
bool Check(int a, int b)
{
    if (b == 1)
    {
        return true;
    }
    if (a % b == 0)
    {
        return false;
    }
    return Check(a, b - 1);
}
bool result = Check(12, 11);
System.Console.WriteLine(result);
