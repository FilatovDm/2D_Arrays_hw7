/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] FillDoubleNumbersArray(int m, int n)

{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble()*10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 1));
            Console.Write(" ");

        }
        Console.WriteLine(" ");
    }
}

Console.Write("Введите количество строк(M): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов(N): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arrayDoubleNumbers = FillDoubleNumbersArray(m, n);
PrintArray(arrayDoubleNumbers);
