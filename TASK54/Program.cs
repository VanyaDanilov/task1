// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void OrderArrayElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int MessageString(string mess)
{
    Console.Write(mess);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void SpecifyArrayNum(int[,] array)
{
    int number = MessageString("Введите число: от 1 до 20: ");

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


Console.Clear();
Console.WriteLine($"Введите размер массива (rows) и (columns) :");
int m = MessageString(" rows: ");
int n = MessageString(" columns : ");

int[,] array = new int[m, n];
SpecifyArrayNum(array);
GetArray(array);
Console.WriteLine();
Console.WriteLine($"sorted array: ");
OrderArrayElement(array);
GetArray(array);
