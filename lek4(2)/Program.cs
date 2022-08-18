//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int DigitCount(int a)
{
    int i = 0;
    while(a > 0)
    {
     i++;
     a /= 10;
    }
    return i;
}
Console.WriteLine(DigitCount(num));