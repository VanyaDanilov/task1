// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int InputNumber(string qsr)
{
    Console.WriteLine($"{qsr}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] MethodArray(int size, int minValue, int maxValue)
{
    int[] resuit = new int[size];
    for (int i = 0; i < size; i++)
    {
        resuit[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resuit;
}

int MethodArraySum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) count+=arr[i];
    }
    return count;
}

int numberN = InputNumber("Введите размер массива (N):");
int numberA = InputNumber("Введите число начала интервала:");
int numberB = InputNumber("Введите число конца интервала:");

int[] array = MethodArray(numberN, numberA, numberB);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма нечётных элементов массива: {MethodArraySum(array)}");
