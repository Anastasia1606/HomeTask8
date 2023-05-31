int[,] arr = new int[4, 4];
int num = 1;
int i = 0;
int j = 0;
int di = 0;
int dj = 1;
for (int k = 0; k < 16; k++)
{
  arr[i, j] = num++;
  if ((i + di < 0) || (i + di >= arr.GetLength(0)) || (j + dj < 0) || (j + dj >= arr.GetLength(1)) || (arr[i + di, j + dj] != 0))
  {
    int temp = di;
    di = dj;
    dj = -temp;
  }
  i += di;
  j += dj;
}
for (i = 0; i < arr.GetLength(0); i++)
{
  for (j = 0; j < arr.GetLength(1); j++)
  {
    Console.Write(arr[i, j] + " ");
  }
  Console.WriteLine();
}
Console.ReadLine();