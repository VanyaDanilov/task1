//Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
//5, 0, 20 -> [1, 2, 5, 7, 19]
//3, 1, 35 -> [6, 1, 33]

Console.WriteLine("Введите число (N) задающих количество элементов массива: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение (a): ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение (b): ");
int numB = Convert.ToInt32(Console.ReadLine());

void RandArray()
{
    int[] arr = new int[numN];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(numA,numB);
    }
    Console.WriteLine($"[{String.Join(",", arr)}]");
}
RandArray();
