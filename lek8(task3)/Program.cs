//  Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


Console.Write("rows: ");
int m = int.Parse(Console.ReadLine());
Console.Write("columns: ");
int n = int.Parse(Console.ReadLine());


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
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

int[] GetRowArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    return newArray;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void FreqArray(int[]array)
{
    int count = 1;
    for(int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] == array[i + 1])
        {
        count++;
        }
        else
        {
            Console.WriteLine($"{array[i]} встречается {count}");
            count = 1;
        }
    }
    Console.WriteLine($"{array[array.Length - 1]} встречается {count}");
}

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
Console.WriteLine();
int[] arr = GetRowArray(myArray);
SortArray(arr);
FreqArray(arr);




