// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

Console.Write("Enter number of rows in the array: ");
int rowNumbers = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns in the array: ");
int columnNumbers = int.Parse(Console.ReadLine()!);


int[,] array = new int[rowNumbers, columnNumbers];

double[] columnAverage = FindColumnAverage(array);


FillArray(array);

PrintArray(array);

PrintArrayAverage(FindColumnAverage(array));


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{

    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = generator.Next(1, 10);
        }
    }
}

double[] FindColumnAverage(int[,] array)
{

    double[] columnAverage = new double[array.GetLength(1)];
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        columnAverage[j] = Math.Round(sum / array.GetLength(0) ,1);
        sum = 0;
    }
    return columnAverage;

    //   return columnAverage[array.GetLength(0)];
}

void PrintArrayAverage(double[] array)
{
    Console.WriteLine($"Average:");

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
}

