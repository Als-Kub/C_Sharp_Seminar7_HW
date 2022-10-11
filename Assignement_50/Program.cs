// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого элимента в массиве нет



Console.Clear();

Console.Write("Enter number of rows in the array: ");
int rowNumbers = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns in the array: ");
int columnNumbers = int.Parse(Console.ReadLine()!);


int[,] array = new int[rowNumbers, columnNumbers];



FillArray(array);

PrintArray(array);

Console.WriteLine($"Array element: {FindArrayElement(array)}");



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

string FindArrayElement(int[,] array)
{
    Console.Write("Enter a row index of an element: ");
    int indexRow = int.Parse(Console.ReadLine()!);

    Console.Write("Enter a column index of an element: ");
    int indexColumn = int.Parse(Console.ReadLine()!);

    string arrayElement = string.Empty;

    if (indexRow > array.GetLength(0) - 1 ||
        indexColumn > array.GetLength(1) - 1 ||
        indexRow < 0 ||
        indexColumn < 0)
    {
        arrayElement = "There is no element with such an index in the array";
    }

    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == indexRow && j == indexColumn)

                    arrayElement = array[i, j].ToString();
            }
        }
    }
    return arrayElement;
}