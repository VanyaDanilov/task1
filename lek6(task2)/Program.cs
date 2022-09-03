//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine("ВВедите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите трктье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTringle(int num1, int num2, int num3)
{
    return num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1;
}

if(CheckTringle(a, b, c))
{
    Console.Write("Равносторонний: ");
    Console.WriteLine("Да");
}
else 
{
    Console.Write("Равносторонний: ");
    Console.WriteLine("Нет");
}