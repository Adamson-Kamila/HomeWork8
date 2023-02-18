
int[,,] getArray()
{
  int[,,] array = new int[2, 2, 2];
  int[] uniqVal = new int[array.Length];
  int uniq = 0;
  int count = 0;

  Random random = new Random();

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        bool flug = true;
        while (flug)
        {
          uniq = random.Next(10, 100);
          for (int n = 0; n < uniqVal.Length; n++)
          {
            if (uniq == uniqVal[n])
            {
              flug = true;
              break;
            }
            else
            {
              flug = false;
            }
          }
        }
        uniqVal[count++] = uniq;
        array[i, j, k] = uniq;
        Console.Write(array[i, j, k] + "\t");
      }
      Console.WriteLine();
    }
  }
  return array;
}

int[,,] array = getArray();