Console.WriteLine("Ведите два числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int sqr1 = num1 * num1;
int sqr2 = num2 * num2;
if((sqr1 == num2) || (sqr2 == num1)){
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}