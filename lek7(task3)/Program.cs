// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:
//1 4 7 2
//5 81 2 9
//8 4 2 4

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

int[,] CorrectArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
       for (int j = 0; j < array.GetLength(1); j++)
       {
           if(j % 2 == 0 && i % 2 == 0)
          {
            array[i,j] *= array[i,j];
          }
       }
   }
   return array;
} 

int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);
Console.WriteLine();
myArray = CorrectArray(myArray);
PrintArray(myArray);
