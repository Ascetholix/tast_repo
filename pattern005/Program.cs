// Паттерн 005: 2х мерный массив счет через одну 10 и 11
// 1 1 2 1 3 1 
// 1 2 2 2 3 2 
// 1 3 2 3 3 3 
// 1 4 2 4 3 4 
// 1 5 2 5 3 5 
// и
// 1 1 1 2 1 3 
// 2 1 2 2 2 3 
// 3 1 3 2 3 3 
// 4 1 4 2 4 3 
// 5 1 5 2 5 3
Console.Clear();

void PrintArray(int[,] arg)
{
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      Console.Write($"{arg[i, j]} ");
    }
    Console.WriteLine();
  }
}

void FillArray(int[,] arg)
{
  int c = 0;
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    c = 1;
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      if (j % 2 == 0)
      {
        arg[i, j] = i + 1;     // if (j % 2 == 1)
      }
      else
      {
        arg[i, j] = c;
        c++;
      }
    }
  }
}

Console.Write("Введите длину строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[rows, cols];

FillArray(arr);
PrintArray(arr);