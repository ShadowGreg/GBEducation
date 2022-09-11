// Задача 1: Напишите цикл, который принимает на вход два
//  числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
const int A = 0;
const int B = 1;
int[] inputData = new int[2];
double answer;
string Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    return strValue;
}
bool Verification(string inputWord)
{
    bool verification = true;
    if (inputWord == "q" || inputWord == "Q")
    {
        verification = false;
    }
    return verification;
}
void MkPow()
{
    answer = Math.Pow(inputData[A], inputData[B]);
}
void Print()
{
    System.Console.Write($"{inputData[A]}, {inputData[B]} -> {answer}");
    System.Console.WriteLine();
}
void InputCycle()
{
    bool inVerification = true;
    string tempParse = "0";
    while (inVerification)
    {
        System.Console.WriteLine("Если хотите выйти - нажмите q или Q");
        for (int i = 0; i < 2; i++)
        {
            tempParse = Prompt("Введите число > ");
            inVerification = Verification(tempParse);
            if (inVerification == false)
            {
                break;
            }
            inputData[i] = int.Parse(tempParse);
        }
        if (tempParse != "q" && tempParse != "Q")
        {
            MkPow();
            Print();
        }
    }
}
InputCycle();