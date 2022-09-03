//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

void FibNum(int n)
{
    int[] fibarr = new int[n];
    fibarr[0] = 0;
    fibarr[1] = 1;
    for(int i = 2; i < n; i++)
    {
         fibarr[i] =  fibarr[i - 1] + fibarr[i - 2];
    }
    var str = string.Join(" ", fibarr);
    Console.WriteLine($"Первые {n} чисел Фибоначи {str} ");
}

FibNum(n);