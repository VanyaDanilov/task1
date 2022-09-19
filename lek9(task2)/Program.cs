// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

int SumNamber(int num)
{
    return num <= 0 ? 0 : num % 10 + SumNamber(num / 10);
}

Console.Write("Число :");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма чисел в числе: " + SumNamber(number));





