//Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine());

  int SumNum(int numN)
  {
    int a = 0;
    int result = 0;
    int counter = Convert.ToString(numN).Length;
   
    for (int i = 0; i < counter; i++)
    {
      a = numN - numN % 10;
      result = result + (numN - a);
      numN = numN / 10;
    }
   return result;
  }

int sumnum = SumNum(numN);
Console.WriteLine("Сумма чисел : " + sumnum);