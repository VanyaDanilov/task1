// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int m = MessageString("rows one martrix: ");
int n = MessageString("coiumns one and two martrix: ");
int b = MessageString("rows two martrix: ");
int number = MessageString("Enter a number: from 1 to 20:  ");
Console.WriteLine();

int[,] firstMartrix = new int[m, n];
SpecifyArrayNum(firstMartrix);
Console.WriteLine($"First matrix:");
GetArray(firstMartrix);
Console.WriteLine();

int[,] secomdMartrix = new int[n, b];
SpecifyArrayNum(secomdMartrix);
Console.WriteLine($"Second matrix:");
GetArray(secomdMartrix);
Console.WriteLine();

int[,] resultMatrix = new int[m, b];

WorkMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Product of matrices: ");
GetArray(resultMatrix);
Console.WriteLine();

void WorkMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
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

