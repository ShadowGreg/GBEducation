// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int lenght = 8;
int[] array = new int[lenght];
void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
}
void PrintArray(int[] inputArray, string firstsimbol, string lastSimbol)
{
    System.Console.Write($"{firstsimbol}{inputArray[0]}, ");
    for (int i = 1; i < inputArray.Length - 1; i++)
    {
        System.Console.Write($"{inputArray[i]}, ");
    }
    System.Console.Write($"{inputArray[inputArray.Length - 1]}{lastSimbol} ");
}
CreateArray(array);
PrintArray(array, "", "");
System.Console.Write("-> ");
PrintArray(array, "[", "]");