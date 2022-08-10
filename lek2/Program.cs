int number = new Random().Next(100,1000);
int num1 = number % 10 ;
int num3 = number / 100;
int result = num3 * 10 + num1;
Console.WriteLine ($"Число: {result} из {number}");






 