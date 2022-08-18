//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(MultiDigital(num));
int MultiDigital(int N)
{
    int a = 1;
    for(int i = 1; i <= N; i++)
    {
        a = a * i;
    }
    return a;
}