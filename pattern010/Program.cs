// Паттерн 010: 2х мерный массив счет   16
// 1 2 3 4 5 
// 2 3 4 5 6 
// 3 4 5 6 7 
// 4 5 6 7 8 
// 5 6 7 8 9
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

  for (int i = 0; i < arg.GetLength(0); i++)
  {

    for (int j = 0; j < arg.GetLength(1); j++)
    {
      {
        arg[i, j] = i + j + 1;
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