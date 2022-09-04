// Задача 2: Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
int randomInt = new Random().Next(100, 1000);
int tailInt = inputInt % 10;
int tempInt = inputInt / 100;
int outputInt = tempInt * 10 + tailInt;

System.Console.WriteLine($"Cлучайное трёхзначное число {randomInt} -> преобразованное {outputInt}");


