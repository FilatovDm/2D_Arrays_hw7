/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] FillArray(int m, int n)
{
    int[,] randomArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = new Random().Next(0, 10);
        }
    }
    return randomArray; 
}

void PrintResult(int rowArray, int columnArray, int m, int n, int[,] array)
{
    if (rowArray > m || columnArray > n)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }

    else
    {
        Console.WriteLine($"Значение элемента на позиции {rowArray}, {columnArray}: {array[rowArray - 1, columnArray - 1]}");
    }
}

Console.Write("Введите через пробел номера строки и столбца: ");
string line = Console.ReadLine();

string[] splitString = line.Split(" ");
int rowArray = Convert.ToInt32(splitString[0]);
int columnArray = Convert.ToInt32(splitString[1]);

int m = 3, n = 4;
int[,] array = FillArray(m, n);

PrintResult(rowArray, columnArray, m, n, array);

// Для проверки правильности выполнения задания ниже блок вывода массива:
{
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

