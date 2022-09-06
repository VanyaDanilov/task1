//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int MessageString(string mess)
{
    Console.Write(mess);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman( m - 1, Akkerman(m, n - 1));
}


int m = MessageString(" m = ");
int n = MessageString(" n = ");
int funAkkerman = Akkerman(n, m);
Console.Write($"m = {m}, n = {n}  ;  A(m,n) = {funAkkerman} ");




