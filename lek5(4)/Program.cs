//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minValue,  int maxValue)
    {
        int[] res = new int[size];

        for(int i = 0; i < size; i++)
        {
            res[i] = new Random().Next(minValue, maxValue + 1);
        }
        return res;
    }

    int check( int[] mas)
    {
        int count = 0;
        for(int i = 0; i < mas.Length; i++)
        {
           if ((10 <= mas[i]) && (100 > mas[i]))
           {
            count++;
           }
        }
        return count;
    }

int[] array = GetArray(123, 0, 200);
Console.WriteLine(String.Join(" ", (array)));
Console.WriteLine($" {check(array)}");
