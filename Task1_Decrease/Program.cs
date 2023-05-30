  int[,] arr = {
    {5, 7, 1},
    {3, 6, 9},
    {2, 4, 8}
  };
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = j + 1; k < arr.GetLength(1); k++)
      {
        if (arr[i, k] > arr[i, j])
        {
          int temp = arr[i, k];
          arr[i, k] = arr[i, j];
          arr[i, j] = temp;
        }
      }
    }
  }
  Console.WriteLine("Упорядоченные по убыванию элементы каждой строки двумерного массива:");
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.ReadLine();
  }
