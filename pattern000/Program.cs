// See https://aka.ms/new-console-template for more information
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
      arg[i, j] ="$";
    }
  }
}

Console.Write("Введите длину строки: ");
int rows =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца: ");
int cols =Convert.ToInt32(Console.ReadLine());

string[,] arr = new string[rows,cols];

FillArray(arr);
PrintArray(arr);
