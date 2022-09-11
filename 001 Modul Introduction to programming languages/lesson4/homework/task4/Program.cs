// Задачи 4: (*) Напишите программу, которая задаёт массив из 8 элементов
//  случайными числами и выводит их на экран. Также ищет второй максимум 
//  (число меньше максимального элемента, но больше всех остальных)
// 8 1 2 4 4 5 3 1 -> 5
// 1 2 6 9 8 1 1 1 -> 8
// 2 1 2 1 1 1 1 1 -> 1
// 1 2 1 2 1 1 1 1 -> 1
// 1 2 3 4 5 6 7 8 -> 7
// 1 2 3 4 5 6 8 7 -> 7
int lenght = 8;
int[] array = new int[lenght];
void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
}

int FindSecondMax(int[] inpuArray)
{
    int firstMax = 0;
    int secondMax = 0;
    foreach (var item in inpuArray)
    {
        if (item > firstMax)
        {
            secondMax = firstMax;
            firstMax = item;
        }
        else if (item > secondMax && item < firstMax)
        {
            secondMax = item;
        }
    }
    return secondMax;
}
void TestStart()
{
    List<int[]> testArrayList = new List<int[]>();
    testArrayList.Add(new int[] { 8, 1, 2, 4, 4, 5, 3, 1 });
    testArrayList.Add(new int[] { 1, 2, 6, 9, 8, 1, 1, 1 });
    testArrayList.Add(new int[] { 2, 1, 2, 1, 1, 1, 1, 1 });
    testArrayList.Add(new int[] { 1, 2, 1, 2, 1, 1, 1, 1 });
    testArrayList.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
    testArrayList.Add(new int[] { 1, 2, 3, 4, 5, 6, 8, 7 });
    List<int> expectedAnsuer = new List<int>();
    expectedAnsuer.Add(5);
    expectedAnsuer.Add(8);
    expectedAnsuer.Add(1);
    expectedAnsuer.Add(1);
    expectedAnsuer.Add(7);
    expectedAnsuer.Add(7);
    Console.Clear();
    System.Console.WriteLine("Test run:");
    foreach (var item in testArrayList.Zip(expectedAnsuer, Tuple.Create))
    {
        System.Console.Write($" Test: {FindSecondMax(item.Item1)} Expected: {item.Item2} for: ");
        Array.ForEach(item.Item1, Console.Write);
        System.Console.WriteLine();
    }
}

TestStart();

void PrintArray(int[] inputArray, string firstsimbol, string lastSimbol)
{
    System.Console.Write($"{firstsimbol}{inputArray[0]}, ");
    for (int i = 1; i < inputArray.Length - 1; i++)
    {
        System.Console.Write($"{inputArray[i]}, ");
    }
    System.Console.Write($"{inputArray[inputArray.Length - 1]}{lastSimbol} ");
}

void MainStart()
{
    System.Console.WriteLine("Main run:");
    CreateArray(array);
    int secondMax = FindSecondMax(array);
    PrintArray(array, "[", "]");
    System.Console.Write($" -> {secondMax}");
}

MainStart();