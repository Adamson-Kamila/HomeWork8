/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] getArray()
{
  Random random = new Random();
  int[,] array = new int[2, 2];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(0, 5);
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}

int[,] getProductArray(int[,] array1, int[,] array2)
{
  int[,] arrayC = new int[array1.GetLength(0), array2.GetLength(1)]; //результирующий массив должен быть равен количеству
  // строк первого массива, и количеству колонок второго массива.
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
      for (int n = 0; n < array2.GetLength(0); n++)
      {
        arrayC[i, j] += array1[i, n] * array2[n, j];
      }     //Console.WriteLine();
    }
  }
  return arrayC;
}

void PrintArray(int[,] arrayC)
{
  for (int i = 0; i < arrayC.GetLength(0); i++)
  {
    for (int j = 0; j < arrayC.GetLength(1); j++)
    {
      Console.Write(arrayC[i, j] + "\t");
    }
    Console.WriteLine();
  }
}


int[,] array1 = getArray();
Console.WriteLine();
int[,] array2 = getArray();
Console.WriteLine();
int[,] arrayC = getProductArray(array1, array2);
Console.WriteLine();
PrintArray(arrayC);

