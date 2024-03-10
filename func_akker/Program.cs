// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Внимание! Введённые Вами числа должны быть положительными:)");
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return akkerman(m - 1, 1);
  else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равна {akkerman(m, n)}");