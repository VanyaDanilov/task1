// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int  MessageString(string mess)
{
    Console.Write(mess);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintSumNumber(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSumNumber(m, n - 1, sum);
}


int m =  MessageString(" m= ");
int n =  MessageString(" n= ");
int temp = m;


if (m > n)
{
    m = n;
    n = temp;
}

Console.Write($"{m}, {n}  ");
PrintSumNumber(m, n, temp = 0);

