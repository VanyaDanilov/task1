//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4      Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write(" rows = ");
int rows = int.Parse(Console.ReadLine());
Console.Write(" columns = ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);

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

int SumDiagonalArray(int[,] array)
{
    int diagonalSam = 0;
    for (int i = 0; i < array.GetLength(0); i++){
       for (int j = 0; j < array.GetLength(1); j++)
       {
           if(i == j)
          {
           diagonalSam += array[i,j];
          }
       }
   }
   return diagonalSam;
} 

int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);
Console.WriteLine();
int resuitSum = SumDiagonalArray(myArray);
Console.WriteLine($" Сумма: {resuitSum}");
