// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void ShowMatrix(double[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

double[,] GetMatrix()
{
  Console.WriteLine("Enter matrix MxN:");
  int m = GetNumber("M = ");
  int n = GetNumber("N = ");
  double[,] arr = new double[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      arr[i, j] = Convert.ToDouble(new Random().Next(-100, 101)) / 10;
    }
  }
  return arr;
}

double[,] matrix = GetMatrix();
ShowMatrix(matrix);
