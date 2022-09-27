// Задача 3: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//функция Аккермана
int ReturnAkkermanFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return ReturnAkkermanFunction(n - 1, 1);
    else
      return ReturnAkkermanFunction(n - 1, ReturnAkkermanFunction(n, m - 1));
}
//Основная программа
System.Console.WriteLine($"m = 2, n = 3 -> A(m,n) = {ReturnAkkermanFunction(2,3)}");
System.Console.WriteLine($"m = 3, n = 2 -> A(m,n) = {ReturnAkkermanFunction(3,2)}");