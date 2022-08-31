int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int lenght = array.Length;
int find = 18;
int index = 0;

while (index<lenght)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
