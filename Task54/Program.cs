/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] getArray()
{
  int[,] array = new int[4, 4];
  Random random = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(1, 11);
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}


void decreasingArray(int[,] array)
{
  int temporary;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = j + 1; k < array.GetLength(1); k++)
      {
        if (array[i, k] > array[i, j])
        {
          temporary = array[i, j];
          array[i, j] = array[i, k];
          array[i, k] = temporary;

        }
      }
    }
  }
}



void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + "\t");
    Console.WriteLine();
  }

}

int[,] array = getArray();
Console.WriteLine();
decreasingArray(array);
PrintArray(array);
