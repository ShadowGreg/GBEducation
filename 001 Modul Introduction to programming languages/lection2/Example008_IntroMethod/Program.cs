
int Max(int arg1, int arg2, int arg3)
{
    int result = 0;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int GetData()
{
    Console.Write("Введите начыение > ");
    return int.Parse(Console.ReadLine());
}

int max = Max(
    Max(GetData(), GetData(), GetData()),
    Max(GetData(), GetData(), GetData()),
    Max(GetData(), GetData(), GetData())
);

System.Console.WriteLine(max);

