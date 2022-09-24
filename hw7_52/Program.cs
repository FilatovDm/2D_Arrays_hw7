/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] FillRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine(" ");
    Console.WriteLine("Случайно сгенерированный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");
    }
}

double[] GetArithmeticMeanArrayColumns(int[,] array, int n)
{
    double[] arithmeticMeanArray = new double[n];
    double sumColumn = 0;
    double arithmeticMean = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumn = sumColumn + array[j, i];
        }
        arithmeticMean = sumColumn / array.GetLength(0);
        arithmeticMeanArray[i] = Math.Round(arithmeticMean, 1);
        sumColumn = 0;
    }
    return arithmeticMeanArray;
}

Console.Write("Введите количество строк(M): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов(N): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillRandomArray(m, n);

PrintArray(array);

double[] arithmeticMeanArray = GetArithmeticMeanArrayColumns(array, n);

Console.WriteLine("Среднее арифметическое каждого столбца: {0}", string.Join("; ", arithmeticMeanArray));
