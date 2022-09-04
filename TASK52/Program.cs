// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void NewPrintArray(double[] array)
{
    int i = 0;
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:f1}" + " ; ");
    }
    double number = array[i];
    Console.WriteLine($"{number:f1}" + " . ");
}

double[] AverageNumber(int[,] array)
{
    double result = 0.0;
    double[] resultArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        result /= array.GetLength(0);
        resultArray[i] = result;
        result = 0;
    }
    return resultArray;
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
double[] newArray = AverageNumber(myArray);
NewPrintArray(newArray);
