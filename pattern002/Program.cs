// Паттерн 002: 2х мерный массив строчный (string) конвертацией из int в string
// 4 4 4 4 
// 3 3 3 3 
// 2 2 2 2 
// 1 1 1 1
// и
// 4 3 2 1 
// 4 3 2 1 
// 4 3 2 1 
// 4 3 2 1 
Console.Clear();

void PrintArray(string[,] arg)
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

void FillArray(string[,] arg)
{
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      arg[i, j] =Convert.ToString(arg.GetLength(0)-i);    // 2 варианта
      // arg[i, j] =Convert.ToString(arg.GetLength(1)-j);
    }
  }
}

Console.Write("Введите длину строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца: ");
int cols = Convert.ToInt32(Console.ReadLine());

string[,] arr = new string[rows, cols];

FillArray(arr);
PrintArray(arr);
