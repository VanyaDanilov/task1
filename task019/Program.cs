Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.Readline());
sqr1 = num % 10;
sqr2 = num / 10;
if(sqr1 == sqr2) 
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
