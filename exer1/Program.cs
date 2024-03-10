// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumber(m, n));

string PrintNumber(int start, int end)
{
  if (start == end) return start.ToString();
  return (start + " " + PrintNumber(start + 1, n));
}
int SumNumber(int m, int n)
{
  if (m == n)
    return n;
  else return m + SumNumber(m + 1, n);
}