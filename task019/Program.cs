Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int sqr1 = num / 10000; 
int sqr2 = num % 100; int sqr5 = sqr2 /10;
int sqr3 = num / 1000; int sqr6 = sqr3 % 10;
int sqr4 = num % 10;
if(sqr1 == sqr4 && sqr5 == sqr6) 
{
    Console.WriteLine("Да");
    Console.WriteLine(num);
}

else
{
    Console.WriteLine("Нет");
}
     
     
