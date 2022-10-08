// Паттерн 007: 2х мерный массив счет сверху вниз и снизу вверх 13
// 1 10 11 20 21 
// 2 9 12 19 22  
// 3 8 13 18 23  
// 4 7 14 17 24  
// 5 6 15 16 25  
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
        if (j % 2 == 0)
        {
          arg[i, j] = c;
        }
        else
        {
          arg[n - 1 - i, j] = c;
        }
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
