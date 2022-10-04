// Паттерн 003: 2х мерный массив строчный (string) счетчикб четный и нечетный
Console.Clear();

void PrintArray(string[,] arg)
{
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      Console.Write($"\t{arg[i, j]} ");
    }
    Console.WriteLine();
  }
}

void FillArray(string[,] arg)
{
  int x = 1;     // для счета и нечетный чисел. x = 2; - для четный чисел
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      arg[i, j] = Convert.ToString(x);
      x++;      // x+=2; - для четных и нечетный чисел
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
