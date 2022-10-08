
// Паттерн 009: 2х мерный массив счет с низу вврех и с верху вниз  15
// 5 6 15 16 25  
// 4 7 14 17 24  
// 3 8 13 18 23  
// 2 9 12 19 22  
// 1 10 11 20 21 
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
          arg[n - 1 - i, j] = c;
        }
        else
        {
          arg[i, j] = c;
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

