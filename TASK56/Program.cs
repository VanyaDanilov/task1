// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine($"Введите размер массива (rows) и (columns) :");
int m = MessageString(" rows: ");
int n = MessageString(" columns : ");
int number = MessageString("Введите диапазон: от 1 до 20: ");

int[,] array = new int[m, n];
SpecifyArrayNum(array);
GetArray(array);

int minSumValue = 0;
int sumValue = SumNamElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumNamElements(array, i);
    if (sumValue > temp)
    {
        sumValue = temp;
        minSumValue = i;
    }
}


int SumNamElements(int[,] array, int i)
{
    int sumNamber = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumNamber += array[i, j];
    }
    return sumNamber;
}

int MessageString(string mess)
{
    Console.Write(mess);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void SpecifyArrayNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(number);
        }
    }
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"{minSumValue + 1} - строкa с минимальной суммой = {sumValue} ");