/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int[,] printArray(int[,] array)
{

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}

int[,] spiralArray()//int[,] array)
{
  int[,] array = new int[4, 4];
  int count = 1;

  for (int j = 0; j < array.GetLength(0); j++)
  {
    array[0, j] = count++;
    //Console.Write(array[0, j] + "\t");
  }

  for (int i = 1; i < array.GetLength(1); i++)
  {
    array[i, 3] = count++;
    //Console.Write(array[i, 3] + "\t");
  }

  for (int j = array.GetLength(0) - 2; j >= 0; j--)
  {
    array[3, j] = count++;
    //Console.Write(array[3, j] + "\t");
  }

  for (int i = array.GetLength(1) - 2; i > 0; i--)
  {
    array[i, 0] = count++;
    //Console.Write(array[i, 0] + "\t");
  }

  for (int j = 1; j < array.GetLength(1) - 1; j++)
  {
    array[1, j] = count++;
    //Console.Write(array[1, j] + "\t");
  }

  for (int j = array.GetLength(1) - 2; j > 0; j--)
  {
    array[2, j] = count++;
    //Console.Write(array[2, j] + "\t");
  }

  return array;
}




// int[,] array = getArray();
//Console.WriteLine();
int[,] array = spiralArray();
Console.WriteLine();
int[,] array1 = printArray(array);