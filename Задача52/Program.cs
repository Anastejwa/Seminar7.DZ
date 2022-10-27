// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] result = GetArray(rows,columns,0,10);
PrintArray(result);
 
int[,] GetArray (int m, int n, int min, int max )
{
    int[,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int[ , ] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(inArray.GetLength(0));
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
    double sum = 0;
       for (int i = 0; i < inArray.GetLength(0); i++)
      {
        sum += inArray[i, j];
      }
      Console.WriteLine($" среднее арифметическое элементов: { sum / inArray.GetLength(0)} ");
    }
}