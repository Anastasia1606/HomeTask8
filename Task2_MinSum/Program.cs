int[,] arr = {
  {5, 7, 1},
  {3, 6, 9},
  {2, 4 ,8}
};
int minSum = int.MaxValue;
int minIndex = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
  int sum = 0;
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    sum += arr[i, j];
  }
  if (sum < minSum)
  {
    minSum = sum;
    minIndex = i;
  }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex + 1}");
Console.ReadLine();
