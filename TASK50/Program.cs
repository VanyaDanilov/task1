//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//m = 1, n =7 -> такого числа в массиве нет


int[,] GetArray(int numRows, int numColumns, int minValue, int maxValue)
{
    int[,] array = new int[numRows, numColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

void FindElemArray(int numRows, int numColumns, int[,] findArray)
{
    int ElemRows = -1;
    int ElemColumns = -1;
    for (int i = 0; i < findArray.GetLength(0); i++)
    {
        for (int j = 0; j < findArray.GetLength(1); j++)
        {
            if (i == numRows && j == numColumns)
            {
                ElemRows = i;
                ElemColumns = j;
            }
        }
    }
    if (ElemRows >= 0)
        Console.WriteLine($"{findArray[ElemRows, ElemColumns]}");
    else
        Console.WriteLine($"Числа нет или вышли за пределы массива.");
}

int MessageString(string mess)
{
    Console.Write($"{mess}");
    return Convert.ToInt32(Console.ReadLine());
}
 
 
int r = MessageString("rows: ");
int c = MessageString("columns: ");
Console.WriteLine();
int minNam = MessageString("Начальный элемент:");
int maxNam = MessageString("Конечный элемент:");
Console.WriteLine();
int[,] myArray = GetArray(r, c, minNam, maxNam);
PrintArray(myArray);
Console.WriteLine();
int Rows = MessageString("Введите номер строки Rows: ") - 1;
int Columns = MessageString("Введите номер столбца Columns: ") - 1;
FindElemArray(Rows, Columns, myArray);
