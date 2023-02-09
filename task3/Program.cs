/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void ShowAverages(int[,] matrix)
{
  Console.Write("среднее значение столбцов ​​: ");
  int sum = 0;
  double average = 0;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      sum += matrix[j,i];
    }
    average = (double)sum / matrix.GetLength(0);
    Console.Write(Math.Round(average, 2) + "; ");
    sum = 0;
  }
}

void ShowMatrix(int[,] matrix)
{
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + "\t");
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

int[,] GetMatrix()
{
  Console.WriteLine("Введите матрицу MxN:");
  int m = GetNumber("M = ");
  int n = GetNumber("N = ");
  int[,] arr = new int[m,n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      arr[i,j] = new Random().Next(1,10);
    }
  }
  return arr;
}

Console.WriteLine("Расчет средних значений в столбцах матрицы.");
int[,] matrix = GetMatrix();
ShowMatrix(matrix);
ShowAverages(matrix);
