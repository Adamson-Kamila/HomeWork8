int[,] getArray()
{
  int[,] array = new int[3, 3];
  Random random = new Random();

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(0, 10);
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}

int[,] counterclockwise(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write(array[2, i] + "\t"); // 2 указывает индекс строки
  }

  for (int j = array.GetLength(1) - 1; j >= 0; j--)
  {
    Console.Write(array[j, 2] + "\t");
  }

  for (int i = array.GetLength(0) - 2; i >= 0; i--)
  {
    Console.Write(array[0, i] + "\t");
  }

  for (int j = 0; j < array.GetLength(0) - 1; j++)
  {
    Console.Write(array[1, j] + "\t");
  }
  return array;

}

int[,] array = getArray();
Console.WriteLine();
int[,] newArray = counterclockwise(array);