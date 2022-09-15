// Задача *: Напишите программу, которая задаёт массив 
// из 8 элементов случайными числами и выводит их на экран. 
// Также ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных) 


int[] array = new int[8];
int[] arrayTemp = array;

int[] CreateArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] = new Random().Next(0, 11);
    }
    return inputArray;
}

void PrintArray(int[] fillArray)
{
    System.Console.Write("[");
    foreach (var item in fillArray)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.Write("]");
}

// void FindSecondMax(int[] inArray)
// {
//     var max = Math.Max(inArray);
//     System.Console.WriteLine($"{max}");
// }

PrintArray(CreateArray(array));
System.Console.WriteLine();
// FindSecondMax(CreateArray(array));