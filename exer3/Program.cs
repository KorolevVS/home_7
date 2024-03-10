// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

class Program
{
  static void PrinArray(int[] myArray, int i = 3)
  {
    if (i < myArray.Length)
    {
      Console.WriteLine(myArray[i]);
      PrinArray(myArray, i - 1);
    }
  }

  static void Main(string[] args)
  {
    int[] myArray = {5, 3, 2, 4 };
    PrinArray(myArray);
  }
}