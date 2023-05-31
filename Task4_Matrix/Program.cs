int[,,] arr = new int[2, 2, 2];
Random rand = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int k = 0; k < arr.GetLength(2); k++)
    {
      int num;
      do
      {
        num = rand.Next(10, 100);
      } 
      while (Contains (arr, num));
      arr[i, j, k] = num;
    }
  }
} 
for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int k = 0; k < arr.GetLength(2); k++)
    {
      Console.WriteLine($"arr[{i}, {j}, {k}] = {arr[i, j, k]}");
    }
  }
}
Console.ReadLine();
static bool Contains(int[,,] arr, int num)
{
  foreach (int item in arr)
  {
    if (item == num)
  {
       return true;
  }
  }
    return false;
  }