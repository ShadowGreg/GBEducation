// Задача со звездочкой: Заполнить массив четной длины таким образом, 
// чтобы значение элемента массива повторялось ровно 2 раза.
// 1,1,2,3,3,2,4,5,4,5
// или
// 1,1,2,2,4,4,5,5
// или
// 1,2,3,3,2,1
int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit && number % 2 == 0)
    {
        return number;
    }
    throw new Exception("Вы ввели не верное значение. Число должно быть чётным");
}

int isZeroElements(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        if (item == 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rndNum = new Random();
    Random rndItem = new Random();
    int[] answer = new int[length];
    while (isZeroElements(answer) > 0)
    {
        int item = rndItem.Next(minRandom, maxRandom);
        int i = rndNum.Next(0, answer.Length);
        int j = rndNum.Next(0, answer.Length);
        if (answer[i] == 0 && answer[j] == 0 && i != j)
        {
            answer[i] = item;
            answer[j] = item;
        }

    }
    return answer;
}

void PrintArray(int[] array)
{
    System.Console.Write($"[{array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}]");
}

const int MIN_ELEMENTS = 2;
const int MAX_ELEMENTS = 99;

int length = Prompt("Введите длину массива > ");
int[] newArray = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(newArray);