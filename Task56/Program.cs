/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] getArray()
{
  int[,] array = new int[5, 7];
  Random random = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(0, 11);
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}

int[] getSumNum(int[,] array)
{
  int[] myArray = new int[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];
      myArray[i] = sum;
    }
  }
  Console.WriteLine("[{0}]", string.Join(",", myArray));
  return myArray;
}

int getMinLine(int[] myArray)
{
  int min = 0;
  for (int i = 1; i < myArray.Length; i++)
  {
    if (myArray[i] < myArray[min])
    {
      min = i;
    }
  }
  return min + 1;
}

int[,] array = getArray();
Console.WriteLine();
int[] myArray = getSumNum(array);
Console.WriteLine();
int min = getMinLine(myArray);
Console.WriteLine(min);