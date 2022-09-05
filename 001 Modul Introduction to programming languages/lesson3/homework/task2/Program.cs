// Задача 2
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

const int XCOORD = 0;
const int YCOORD = 1;
const int ZCOORD = 2;

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int[] InsertCoords()
{
    int[] temp = new int[3];
    temp[XCOORD] = Prompt("Введите x > ");
    temp[YCOORD] = Prompt("Введите y > ");
    temp[ZCOORD] = Prompt("Введите Z > ");
    return temp;
}

double Length(int[] firstPoint, int[] secondPoint)
{
    return Math.Sqrt(Math.Pow(firstPoint[XCOORD] - secondPoint[XCOORD], 2)
    + Math.Pow(firstPoint[YCOORD] - secondPoint[YCOORD], 2)
    + Math.Pow(firstPoint[ZCOORD] - secondPoint[ZCOORD], 2));
}

System.Console.WriteLine("Введдите координаты первой точки");
int[] firstPoint = InsertCoords();
System.Console.WriteLine("Введдите координаты второй точки");
int[] secondPoint = InsertCoords();
System.Console.WriteLine($"Длина {Length(firstPoint,secondPoint):f2}");