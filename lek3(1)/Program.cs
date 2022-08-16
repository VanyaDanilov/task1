Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLain());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLain());

if( x > 0 && y > 0)
{
    Console.Write("1");
}

if(x < 0 && y > 0)
{
    Console.Write("2");  
}

if(x < 0 && y < 0)
{
    Console.Write("3");   
}

if(x > 0 && y < 0)
{
    Console.Write("4");  
}