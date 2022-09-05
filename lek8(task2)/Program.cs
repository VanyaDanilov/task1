// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
            array[i, j] = new Random().Next(-100, 100);
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


int[,] NewArray(int[,] array)
{
int[,] tmp = new int[array.GetLength(0), array.GetLength(1)];

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
tmp[i, j] = array[j, i];
}
}
return tmp;
}

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
Console.WriteLine();
if (myArray.GetLength(0) == myArray.GetLength(1))
{
PrintArray(NewArray(myArray));
}
else
Console.Write("Кол-во столбцов не совпадает с кол-во строк!");

