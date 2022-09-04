// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
int firstInt = Prompt("Введите число > ");
int secondInt = Prompt("Введите число > ");

if (firstInt>secondInt)
{
    CheckingMultiplicity(firstInt,secondInt);
} 
else 
{
    CheckingMultiplicity(secondInt,firstInt);
}

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

void CheckingMultiplicity(int firstNum, int secondNum)
{

    if (firstNum % secondNum == 0)
    {
        System.Console.WriteLine($"{firstNum}, {secondNum} -> кратно");
    }
    else
    {
        System.Console.WriteLine($"{firstNum}, {secondNum} -> не кратно, остаток {firstNum % secondNum}");
    }

}