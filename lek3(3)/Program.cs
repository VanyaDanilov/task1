Console.WriteLine("Введите координаты x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Растояние между двумя точками на плоскости равно {distance:f3}");

