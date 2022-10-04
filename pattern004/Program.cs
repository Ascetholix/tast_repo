// Паттерн 004: 2х мерный массив строчный (string) таблица умножения 
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
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      arg[i, j] =Convert.ToString((i+1)*(j+1));    // i=0; j=0; (i+1)+(j)
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