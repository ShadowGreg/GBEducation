// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8
int randomInt = new Random().Next(10, 99999);
int max = 0;
int temp = randomInt % 10;
int i = randomInt;
while (i > 0)
{
    if (max < temp)
    {
        max = temp;
    }
    i= i/10;
    temp = randomInt % 10;
}
System.Console.WriteLine(randomInt);
System.Console.WriteLine(max);

