// Паттерн 008: 2х мерный массив счет снизу вверх 14
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
  int n = arg.GetLength(0);
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    c = i + 1;
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      {
        arg[n - 1 - i, j] = c;
        c += n;
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
