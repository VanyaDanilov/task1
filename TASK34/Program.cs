// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

  int InputNum(string qsr)
{
    Console.WriteLine($"{qsr}");
    return Convert.ToInt32(Console.ReadLine());
}

void CheckNumber(int checkNum)
{
    int count = 0;
    int check = checkNum;
    while (check != 0)
    {
        check = check / 10;
        count++;
    }
    if (count != 3)
    {
        Console.WriteLine($"Число {checkNum} не являеться трехзначным");
    }
}

int[] MethodArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int MethodArrayCount(int[] arr)
{
    int CountM = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) CountM++;
    }
    return CountM;
}

int numberN = InputNum("Введите размер массива (N):");
int numberA = InputNum("Введите трёхзначное число, начало интервала:");
CheckNumber(numberA);
int numberB = InputNum("Ввидите трехзначное чилсло, конец интервала:");
CheckNumber(numberB);

int[] array = MethodArray(numberN, numberA, numberB);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Количество чётных чисел: {MethodArrayCount(array)}");
