//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetBinary(int num)
{
    string result = " ";
    while(num > 0)
    {
      result += Convert.ToString(num % 2);
      num /= 2;
    }
    result.ToCharArray().Reverse();
    return  int.Parse(result);
}

Console.WriteLine($"{GetBinary(number)}");