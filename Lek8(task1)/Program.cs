// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetArray(int numRows, int numColumns, int minValue, int maxValue)
{
    int[,] array = new int[numRows, numColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}


void CoupElementArray(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.Write("rows: ");
int numRows = int.Parse(Console.ReadLine());
Console.Write("columns: ");
int numColumns = int.Parse(Console.ReadLine());
Console.Write("Начальное число: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Конечное число: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(numRows,  numColumns, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();
CoupElementArray(myArray);
PrintArray(myArray);


