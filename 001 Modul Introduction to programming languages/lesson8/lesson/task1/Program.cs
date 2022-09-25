int[,] ReplaceRows(int[,] arr)
{
    int tmp = 0;
    int lastpos = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        tmp = arr[0,i];
        arr[0,i] = arr[lastpos,i];
        arr[lastpos,i] = tmp;
    }
    return arr;
}

int rows = Prompt("Кол-во строк: ");
int cols = Prompt("Кол-во столбцов: ");
int[,] myArray = GenerateArray(rows, cols, 5, 10);
PrintArray(myArray);
myArray = ReplaceRows(myArray);
PrintArray(myArray);
