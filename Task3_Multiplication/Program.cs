int[,] matrix1 = {
  {2, 4},
  {3, 2}
};
int[,] matrix2 = {
  {3, 4},
  {3, 3}
};
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
  Console.WriteLine("Невозможно умножить матрицы!");
  Console.ReadLine();
  return;
}
int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
  for (int j = 0; j < matrix2.GetLength(1); j++)
  {
    int sum = 0;
    for (int k = 0; k < matrix1.GetLength(1); k++)
    {
      sum += matrix1[i, k] * matrix2[k, j];
    }
    resultMatrix[i, j] = sum;
  }
}
Console.WriteLine("Произведение двух матриц:");
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
  for (int j = 0; j < resultMatrix.GetLength(1); j++)
  {
    Console.Write(resultMatrix[i, j] + " ");
  }
  Console.WriteLine();
}
Console.ReadLine();
